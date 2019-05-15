<%@ Page Language="C#" AutoEventWireup="true" CodeFile="movie.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <script src="lib/@aspnet/signalr/dist/browser/signalr.js" type="text/javascript"></script>
    <script src="Style/js/jquery-3.3.1.min.js"></script>
    <script src="Style/js/jquery.seat-charts.js"></script>
    <script src="Style/js/jquery.nicescroll.js"></script>
    <script src="Style/js/scripts.js"></script>
    
    <script src="Style/js/signalR.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <h1>Movie Ticket Booking Widget</h1>
	        <div class="main">
		        <h2>Multiplex Theatre Showing Screen 1</h2>
		        <div class="demo">
			        <div id="seat-map">
				        <div class="front">SCREEN</div>					
			        </div>
			        <div class="booking-details">
				        <ul class="book-left">
					        <li>Movie </li>
					        <li>Time </li>
					        <li>Tickets</li>
					        <li>Total</li>
					        <li>Seats :</li>
				        </ul>
				        <ul class="book-right">
					        <li>: Gingerclown</li>
					        <li>: April 3, 21:00</li>
					        <li>: <span id="counter">0</span></li>
					        <li>: <b><i>$</i><span id="total">0</span></b></li>
				        </ul>
				        <div class="clear"></div>
				        <ul id="selected-seats" class="scrollbar scrollbar1"></ul>
			
						
				        <button class="checkout-button1">Book Now</button>	
				        <div id="legend"></div>
			        </div>
			        <div style="clear:both"></div>
	                </div>
                </div>
            </div>
    </form>
</body>
</html>
