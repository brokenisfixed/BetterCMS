﻿/*jslint unparam: true, white: true, browser: true, devel: true */
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="bcms.sidemenu.js" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------

bettercms.define('bcms.sidemenu', ['bcms.jquery', 'bcms', 'bcms.security', 'bcms.store'], function ($, bcms, security, store) {
    'use strict';

    var sidemenu = {},

    // Classes that are used to maintain various UI states:
        classes = {
            stateOpen: 'bcms-state-open',
            sideMenuRight: 'bcms-sidemenu-right',
            editingOnClass: 'bcms-on'
        },

    // Selectors used in the module to locate DOM elements:
        selectors = {
            container: '#bcms-sidemenu',
            leftRightHandle: '#bcms-sidemenu-position-handle',
            openCloseHandle: '#bcms-sidemenu-hide',
            editOnOffHandle: '#bcms-sidemenu-switch',
            draggHandle: '#bcms-sidemenu-draghandle',
            html: 'html',
            button: '.bcms-sidemenu-button',
            footerTextHolder: '.bcms-sidemenu-stick-text'
        },

    // Keys used for localStorage:
        keys = {
            sideMenuOnTheRight: 'bcms.sideMenuOnTheRight',
            sideMenuOffsetTop: 'bcms.sideMenuOffsetTop',
            sideMenuOpen: 'bcms.sideMenuOpen',
            editingOn: 'bcms.editingOn'
        },

    // Holds jQuery sidemenu object:
        sidemenuContainer,

        links = {},
        globalization = {
            stickRightMenuTitle: null,
            stickLeftMenuTitle: null
        };

    // Assign objects to module
    sidemenu.classes = classes;
    sidemenu.selectors = selectors;
    sidemenu.links = links;
    sidemenu.globalization = globalization;

    /**
    * Opens sidebar menu.
    */
    sidemenu.open = function (doNotAnimate) {
        var isOnRightSide = sidemenuContainer.hasClass(classes.sideMenuRight),
            sideMenuWidth = '0px',
            css = isOnRightSide
                ? { 'right': sideMenuWidth }
                : { 'left': sideMenuWidth };

        store.set(keys.sideMenuOpen, '1');

        if (doNotAnimate) {
            sidemenuContainer.css(css).addClass(classes.stateOpen);
            return;
        }

        sidemenuContainer.animate(css, 100, function () {
            sidemenuContainer.addClass(classes.stateOpen);
        });
    };

    /**
    * Closes sidebar menu.
    */
    sidemenu.close = function (doNotAnimate) {
        var isOnRightSide = sidemenuContainer.hasClass(classes.sideMenuRight),
			sideMenuWidth = '-260px',
			css = isOnRightSide
					? { 'right': sideMenuWidth }
					: { 'left': sideMenuWidth };

        store.remove(keys.sideMenuOpen);

        if (doNotAnimate) {
            sidemenuContainer.removeClass(classes.stateOpen);
            return;
        }

        sidemenuContainer.animate(css, 100, function () {
            sidemenuContainer.removeClass(classes.stateOpen);
        });
    };

    /**
    * Indicates whether sidebar is open.
    */
    sidemenu.isOpen = function () {
        return sidemenuContainer.hasClass(classes.stateOpen);
    };

    /**
    * Moves sidebar menu to the right.
    */
    sidemenu.moveToRight = function () {
        store.set(keys.sideMenuOnTheRight, '1');
        sidemenuContainer.css({
            'left': 'auto',
            'right': sidemenu.isOpen() ? '0px' : '-260px'
        }).addClass(classes.sideMenuRight);
    };

    /**
    * Moves sidebar menu to the left.
    */
    sidemenu.moveToLeft = function () {
        store.remove(keys.sideMenuOnTheRight);
        sidemenuContainer.css({
            'left': sidemenu.isOpen() ? '0px' : '-260px',
            'right': 'auto'
        }).removeClass(classes.sideMenuRight);
    };

    /**
    * Turns edit mode ON.
    */
    sidemenu.turnEditModeOn = function () {
        bcms.trigger(bcms.events.editModeOn);
    };

    /**
    * Turns edit mode OFF.
    */
    sidemenu.turnEditModeOff = function () {
        bcms.trigger(bcms.events.editModeOff);
    };

    /**
    * Initializes sidebar module.
    */
    sidemenu.init = function() {

        bcms.logger.debug('Initialize sidebar');
        $(selectors.container).hide();
        sidemenuContainer = $(selectors.container);

        var offsetTop = store.get(keys.sideMenuOffsetTop),
            isMenuOnTheRight = store.get(keys.sideMenuOnTheRight),
            isSideMenuOpen = store.get(keys.sideMenuOpen),
            editingOn = store.get(keys.editingOn),
            middleOfThePage;



        function setOffset(offset) {
            var windowHeight = $(window).height();
            var sidemenuHeight = sidemenuContainer.height();
            if (offset > windowHeight - sidemenuHeight) {
                sidemenuContainer.css('top', (windowHeight - sidemenuHeight - 20) + 'px');
            } else if (offset >= 0) {
                sidemenuContainer.css('top', offset + 'px');
            }
        }

        function onWindowResize() {
            if (offsetTop) {
                setOffset(offsetTop);
            }
        }
        if (offsetTop) {
            setOffset(offsetTop);
        }

        if (isMenuOnTheRight) {
            sidemenu.moveToRight(true);
        }

        if (isSideMenuOpen) {
            sidemenu.open(true);
        }

        var canTurnEditOn = security.IsAuthorized(["BcmsEditContent", "BcmsPublishContent"]);
        if (editingOn && canTurnEditOn) {
            sidemenu.turnEditModeOn();
        }

        $(selectors.leftRightHandle).on('click', function() {
            if (sidemenuContainer.hasClass(classes.sideMenuRight)) {
                sidemenu.moveToLeft();
            } else {
                sidemenu.moveToRight();
            }
        });

        $(selectors.openCloseHandle).on('click', function() {
            if (sidemenu.isOpen()) {
                sidemenu.close();
            } else {
                sidemenu.open();
            }
        });

        if (canTurnEditOn) {
            $(selectors.editOnOffHandle).on('click', function () {
                if ($(selectors.html).hasClass(classes.editingOnClass)) {
                    sidemenu.turnEditModeOff();
                } else {
                    sidemenu.turnEditModeOn();
                }
            });
        }

        sidemenuContainer.draggable({
            axis: 'y',
            handle: selectors.draggHandle,
            containment: 'window',
            stop: function (event, ui) {
                var top = ui.position.top;

                var wHeight = $(window).height();
                var sHeight = sidemenuContainer.height();
                if (top > wHeight - sHeight) {
                    top = (windowHeight - sidemenuHeight - 20);
                    sidemenuContainer.css('top', top +'px');
                } else if (top < 0) {
                    top = 0;
                    sidemenuContainer.css('top', '0px');
                }
                offsetTop = top;
                store.set(keys.sideMenuOffsetTop, top);
            },
            start: function () {
                middleOfThePage = $(window).width() / 2;
            },
            drag: function (event) {
                var left = event.clientX;
                if (isMenuOnTheRight) {
                    if (left < middleOfThePage) {
                        isMenuOnTheRight = false;
                        sidemenu.moveToLeft();
                    }
                } else {
                    if (left > middleOfThePage) {
                        isMenuOnTheRight = true;
                        sidemenu.moveToRight();
                    }
                }
            }
        });

        sidemenuContainer.show();
        window.addEventListener('resize', onWindowResize);
    };

    bcms.registerInit(sidemenu.init);
    
    return sidemenu;
});
