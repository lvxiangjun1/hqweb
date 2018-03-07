/*ÆÁ±ÎËùÓÐµÄjs´íÎó*/
function killerrors() { 
return true; 
} 
window.onerror = killerrors; 

/*Ê×Ò³Í¼Æ¬ÂÖ»»*/
		var theInt = null;
		var $crosslink, $navthumb, curclicked, $title, $crosslinkId;
		var curclicked = 0
		theInterval = function(cur){
			clearInterval(theInt);
			if( typeof cur != 'undefined' ){
				curclicked = cur;
			}
			$crosslink.each(function(index){
				$(this).attr({ href: "#"+index, id: index });
				crosslinkId = $(this).attr("id")
			})			
			$crosslink.removeClass("active-thumb").eq(curclicked).addClass("active-thumb");
			$title.css({"display":"none"}).eq(curclicked).css({"display":"block"});
			$panelNum.fadeOut("slow").removeClass("current").eq(curclicked).fadeIn("slow").addClass("current");
			if(curclicked == 0 || curclicked == 1 || curclicked == 2 || curclicked == 3 ){
				++curclicked;
			} else if(curclicked == 4){
				curclicked = 0	
			}
			theInt = setInterval(function(){
				$crosslink.removeClass("active-thumb").eq(curclicked).addClass("active-thumb");
				$title.css({"display":"none"}).eq(curclicked).css({"display":"block"});
				$panelNum.fadeOut("slow").removeClass("current").eq(curclicked).fadeIn("slow").addClass("current");
				curclicked++;
				if( 6 == curclicked )
					curclicked = 0;				
			}, 3000);
		};
		$(function(){
			$navthumb = $(".cross-link img");
			$crosslink = $(".cross-link");
			$panelNum = $(".main-photo-slider a");
			$title = $(".photo-meta-data a");
			theInterval();
			$navthumb.click(function() {
				var $this = $(this);
				theInterval($this.parent().attr('href').slice(1));
				return false;
			});
			$panelNum.hover(function(){
				clearInterval(theInt);
			},function(){
				theInterval();
			})
		});
		
