#include <iostream>
#include <exo/util/delegate.hpp>

using exo::util::delegate_unsafe;


bool any_check_fail = false;

int last_class_id;
int last_func_id;
int last_arg;


static void clear_state()
{
    last_class_id = 0;
    last_func_id = 0;
    last_arg = 0;
}

static void check(delegate_unsafe<void (int)> d, int class_id, int func_id)
{
    clear_state();


    const int arg = 456;
    d(arg);


    std::cout << "{" << class_id << ", " << func_id << ", " << arg << "} - ";

    if (last_class_id == class_id
            && last_func_id == func_id
            && last_arg == arg)
        std::cout << "success";
    else
    {
        any_check_fail = true;
        std::cout << "fail with {" << last_class_id << ", " << last_func_id << ", " << last_arg << "}";
    }

    std::cout << std::endl;
}


static void static_func(int arg)
{
    last_func_id = 1;
    last_arg = arg;
}

class base_class
{
protected:

    int class_id;

public:

    base_class(int class_id_)
    : class_id(class_id_)
    {}

    virtual ~base_class() {}


    void member_func(int arg)
    {
        last_class_id = class_id;
        last_func_id = 2;
        last_arg = arg;
    }

    void const_member_func(int arg) const
    {
        last_class_id = class_id;
        last_func_id = 3;
        last_arg = arg;
    }

    virtual void virtual_member_func(int arg)
    {
        last_class_id = class_id;
        last_func_id = 4;
        last_arg = arg;
    }

    static void static_member_func(int arg)
    {
        last_func_id = 5;
        last_arg = arg;
    }
};

class other_class
{
    int class_id;

public:

    other_class(int class_id_)
    : class_id(class_id_)
    {}

    virtual ~other_class() {}

    virtual void unused_virtual_function(int arg)
    {
        last_class_id = class_id;
        last_func_id = 9;
        last_arg = arg;
    }

    virtual void tricky_virtual_function(int arg) = 0;
};

class very_big_class
{
    int lets_make_things_complicated[400];
public:
    virtual ~very_big_class() {}
};

class derived_class : public very_big_class, virtual public other_class, virtual public base_class
{
    int class_id;

public:

    derived_class(int my_id, int base_id, int other_id)
    : other_class(other_id)
    , base_class(base_id)
    , very_big_class()
    , class_id(my_id)
    {}

    void simple_derived_function(int arg)
    {
        last_class_id = class_id;
        last_func_id = 6;
        last_arg = arg;
    }

    virtual void another_virtual_function(int arg)
    {
        last_class_id = class_id;
        last_func_id = 7;
        last_arg = arg;
    }

    virtual void tricky_virtual_function(int arg)
    {
        last_class_id = class_id;
        last_func_id = 8;
        last_arg = arg;
    }
};


int main()
{
    delegate_unsafe<void (int)> d;


    d = static_func;
    check(d, 0, 1);

    base_class bc(123);

    d = delegate_unsafe<>::create(bc, &base_class::member_func);
    check(d, 123, 2);

    d = delegate_unsafe<>::create(bc, &base_class::const_member_func);
    check(d, 123, 3);

    d = delegate_unsafe<>::create(bc, &base_class::virtual_member_func);
    check(d, 123, 4);

    d = base_class::static_member_func;
    check(d, 0, 5);

    derived_class dc(234, 1234, 567);

    d = delegate_unsafe<>::create(dc, &derived_class::simple_derived_function);
    check(d, 234, 6);

    d = delegate_unsafe<>::create(dc, &derived_class::another_virtual_function);
    check(d, 234, 7);

    d = delegate_unsafe<>::create(dc, &derived_class::tricky_virtual_function);
    check(d, 234, 8);

    d = delegate_unsafe<>::create(dc, &other_class::tricky_virtual_function);
    check(d, 234, 8);

    d = delegate_unsafe<>::create(dc, &base_class::virtual_member_func);
    check(d, 1234, 4);

    d = delegate_unsafe<>::create(dc, &other_class::unused_virtual_function);
    check(d, 567, 9);


    return any_check_fail ? 1 : 0;
}
