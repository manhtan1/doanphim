import React from 'react'
import "../css/style.css"
import "../css/gozha-nav.css"
import companyLogo from '../img/logohutech.png';
// import companyLogo from '../img/logogif.gif';

export default function Navbar() {
  return (
    <header className="header-wrapper header-wrapper--home">
            <div className="container">
                <a href='index.html' className="logo">
                  <img src={companyLogo} alt="logo"/>
                </a>
                
                <nav id="navigation-box">
                    <a href="#" id="navigation-toggle">
                        <span className="menu-icon">
                            <span className="icon-toggle" role="button" aria-label="Toggle Navigation">
                              <span className="lines"></span>
                            </span>
                        </span>
                    </a>
                    
                    <ul id="navigation">
                        <li>
                            <span className="sub-nav-toggle plus"></span>
                            <a href="#">Phim</a>
                            <ul>
                                <li className="menu__nav-item"><a href="movie-page-left.html">Phim đang chiếu </a></li>
                                <li className="menu__nav-item"><a href="movie-page-right.html">Phim sắp chiếu</a></li>
                                
                            </ul>
                        </li>
                        <li>
                            <span className="sub-nav-toggle plus"></span>
                            <a href="page-elements.html">Rạp chiếu</a>
                            <ul>
                                <li className="menu__nav-item"><a href="typography.html">Tất cả Rạp</a></li>
                                <li className="menu__nav-item"><a href="page-elements.html">Rạp đặc biệt</a></li>
                                <li className="menu__nav-item"><a href="column.html">Rạp sắp mở</a></li>
                            
                            </ul>
                        </li>
                        <li>
                            <span className="sub-nav-toggle plus"></span>
                            <a href="page-elements.html">Thành viên</a>
                            <ul>
                                <li className="menu__nav-item"><a href="book1.html">Tài khoản</a></li>
                                <li className="menu__nav-item"><a href="book2.html">Quyền lợi</a></li>
                                
                            </ul>
                        </li>
                        <li>
                            <span className="sub-nav-toggle plus"></span>
                            <a href="gallery-four.html">Dịch vụ</a>
                            <ul>
                                <li className="menu__nav-item"><a href="gallery-four.html">Quầy vé Online</a></li>
                                <li className="menu__nav-item"><a href="gallery-three.html">Đặt vé nhóm và Thuê rạp</a></li>
                                <li className="menu__nav-item"><a href="gallery-two.html">Thẻ quà tặng</a></li>
                            </ul>
                        </li>
                        <li>
                            <span className="sub-nav-toggle plus"></span>
                            <a href="news-left.html">Thông tin</a>
                            <ul>
                                <li className="menu__nav-item"><a href="news-left.html">Tuyển dụng</a></li>
                                <li className="menu__nav-item"><a href="news-right.html">Giới thiệu</a></li>
                                <li className="menu__nav-item"><a href="news-right.html">Ưu đãi</a></li>

                                
                            </ul>
                        </li>
                        
                    </ul>
                </nav>
                
                <div className="control-panel">
                    <div className="auth auth--home">
                      <div className="auth__show">
                        <span className="auth__image">
                          <img src={companyLogo} alt="logo"/>
                        </span>
                      </div>
                      <a href="#" className="btn btn--sign btn--singin">
                          me
                      </a>
                        <ul className="auth__function">
                            <li><a href="#" className="auth__function-item">Watchlist</a></li>
                            <li><a href="#" className="auth__function-item">Booked tickets</a></li>
                            <li><a href="#" className="auth__function-item">Discussion</a></li>
                            <li><a href="#" className="auth__function-item">Settings</a></li>
                        </ul>

                    </div>
                    <a href="#" className="btn btn-md btn--warning btn--book btn-control--home login-window">Book a ticket</a>
                </div>

            </div>
        </header>
  )
}
