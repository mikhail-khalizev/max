//#include <gtkmm.h>

#include <boost/thread/thread.hpp>
#include "program/raw_program.hpp"
#include "x86/instructions.hpp"


static void raw_program_start()
{
    raw_program::init_x86_dos_prog();
    raw_program::x86::correct_function_position(0);
}

//class my_area : public Gtk::DrawingArea
//{
//    Glib::RefPtr<Gdk::Pixbuf> image;
//
//public:
//
//    my_area()
//    : image(Gdk::Pixbuf::create_from_file("/home/micky53/Изображения/Природа/268135.jpg")) {}
//
//    my_area(BaseObjectType * cobject, const Glib::RefPtr<Gtk::Builder>&)
//    : Gtk::DrawingArea(cobject)
//    , image(Gdk::Pixbuf::create_from_file("/home/micky53/Изображения/Природа/268135.jpg")) {}
//
//    virtual ~my_area() {}
//
//protected:
//
//    virtual bool on_draw(const Cairo::RefPtr<Cairo::Context> & cr)
//    {
////        auto a = image -> get_bits_per_sample(); // 8
////        auto b = image -> get_colorspace(); // 0
////        auto c = image -> get_rowstride(); // 0x854
//
//
//        Gdk::Cairo::set_source_pixbuf(cr, image, 10, 90);
//        cr -> rectangle(0, 0, image -> get_width(), image -> get_height());
//        cr -> fill();
//        return true;
//
////        Gtk::Allocation allocation = get_allocation();
////        const auto width = allocation.get_width();
////        const auto height = allocation.get_height();
////
////        auto xc = width / 2;
////        auto yc = height / 2;
////
////        cr -> set_line_width(10.0);
////        cr -> set_source_rgb(0.0, 0.8, 0.0);
////
////        cr -> move_to(0, 0);
////        cr -> line_to(xc, yc);
////        cr -> line_to(0, height);
////        cr -> move_to(xc, yc);
////        cr -> line_to(width, yc);
////        cr -> stroke();
////
////        return true;
//    }
//};

int main(int argc, char * argv[])
{
//    Gtk::Main kit(argc, argv);

#if 0
    Glib::RefPtr<Gtk::Builder> builder = Gtk::Builder::create_from_file("main.glade");


    Gtk::Window * main_win = NULL;
    builder -> get_widget("window_main", main_win);
    if (main_win == NULL)
        throw std::exception();

    my_area * draw_aria = NULL;
    builder -> get_widget_derived("drawingarea_main", draw_aria);
    if (draw_aria == NULL)
        throw std::exception();


    draw_aria -> set_size_request(640, 480);

    boost::thread thread_raw_program(raw_program_start);

    kit.run(*main_win);
    thread_raw_program.join();
#else
    raw_program_start();
#endif
    return 0;
}
