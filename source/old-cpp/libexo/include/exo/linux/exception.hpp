#ifndef EXO_LINUX_EXCEPTION_HPP_INCLUDED
#define EXO_LINUX_EXCEPTION_HPP_INCLUDED

#include <stdexcept>


#ifdef linux
/* Объявлять "linux" маленькими буквами было плохой идеей. Следовало бы объявить "LINUX". */
#undef linux
#endif


namespace exo {
namespace linux {
namespace exception {


void throw_errno();
void throw_exception(int err);


/* @todo
 * В general добавить дополнительное текстовое поле. (what -> "Открытие файла './hehe': Нет файла.") ?
 */
class general : public std::exception
{
protected:

    int err;

public:

    general(int err);

    virtual const char * what() const throw();


    int get_error() const
    {
        return err;
    }

    bool is_success() const
    {
        return err == 0;
    }

    bool is_not_success() const
    {
        return ! is_success();
    }


    static general success()
    {
        return general(0);
    }
};


class address_family_not_supported : public general
{
public:
    address_family_not_supported();
};

class address_in_use : public general
{
public:
    address_in_use();
};

class address_not_available : public general
{
public:
    address_not_available();
};

class already_connected : public general
{
public:
    already_connected();
};

class argument_list_too_long : public general
{
public:
    argument_list_too_long();
};

class argument_out_of_domain : public general
{
public:
    argument_out_of_domain();
};

class bad_address : public general
{
public:
    bad_address();
};

class bad_file_descriptor : public general
{
public:
    bad_file_descriptor();
};

class bad_message : public general
{
public:
    bad_message();
};

class broken_pipe : public general
{
public:
    broken_pipe();
};

class connection_aborted : public general
{
public:
    connection_aborted();
};

class connection_already_in_progress : public general
{
public:
    connection_already_in_progress();
};

class connection_refused : public general
{
public:
    connection_refused();
};

class connection_reset : public general
{
public:
    connection_reset();
};

class cross_device_link : public general
{
public:
    cross_device_link();
};

class destination_address_required : public general
{
public:
    destination_address_required();
};

class device_or_resource_busy : public general
{
public:
    device_or_resource_busy();
};

class directory_not_empty : public general
{
public:
    directory_not_empty();
};

class executable_format_error : public general
{
public:
    executable_format_error();
};

class file_exists : public general
{
public:
    file_exists();
};

class file_too_large : public general
{
public:
    file_too_large();
};

class filename_too_long : public general
{
public:
    filename_too_long();
};

class function_not_supported : public general
{
public:
    function_not_supported();
};

class host_unreachable : public general
{
public:
    host_unreachable();
};

class identifier_removed : public general
{
public:
    identifier_removed();
};

class illegal_byte_sequence : public general
{
public:
    illegal_byte_sequence();
};

class inappropriate_io_control_operation : public general
{
public:
    inappropriate_io_control_operation();
};

class interrupted : public general
{
public:
    interrupted();
};

class invalid_argument : public general
{
public:
    invalid_argument();
};

class invalid_seek : public general
{
public:
    invalid_seek();
};

class io_error : public general
{
public:
    io_error();
};

class is_a_directory : public general
{
public:
    is_a_directory();
};

class message_size : public general
{
public:
    message_size();
};

class network_down : public general
{
public:
    network_down();
};

class network_reset : public general
{
public:
    network_reset();
};

class network_unreachable : public general
{
public:
    network_unreachable();
};

class no_buffer_space : public general
{
public:
    no_buffer_space();
};

class no_child_process : public general
{
public:
    no_child_process();
};

class no_link : public general
{
public:
    no_link();
};

class no_lock_available : public general
{
public:
    no_lock_available();
};

class no_message_available : public general
{
public:
    no_message_available();
};

class no_message : public general
{
public:
    no_message();
};

class no_protocol_option : public general
{
public:
    no_protocol_option();
};

class no_space_on_device : public general
{
public:
    no_space_on_device();
};

class no_stream_resources : public general
{
public:
    no_stream_resources();
};

class no_such_device_or_address : public general
{
public:
    no_such_device_or_address();
};

class no_such_device : public general
{
public:
    no_such_device();
};

class no_such_file_or_directory : public general
{
public:
    no_such_file_or_directory();
};

class no_such_process : public general
{
public:
    no_such_process();
};

class not_a_directory : public general
{
public:
    not_a_directory();
};

class not_a_socket : public general
{
public:
    not_a_socket();
};

class not_a_stream : public general
{
public:
    not_a_stream();
};

class not_connected : public general
{
public:
    not_connected();
};

class not_enough_memory : public general
{
public:
    not_enough_memory();
};

class not_supported : public general
{
public:
    not_supported();
};

class operation_canceled : public general
{
public:
    operation_canceled();
};

class operation_in_progress : public general
{
public:
    operation_in_progress();
};

class operation_not_permitted : public general
{
public:
    operation_not_permitted();
};

class operation_not_supported : public general
{
public:
    operation_not_supported();
};

class operation_would_block : public general
{
public:
    operation_would_block();
};

class owner_dead : public general
{
public:
    owner_dead();
};

class permission_denied : public general
{
public:
    permission_denied();
};

class protocol_error : public general
{
public:
    protocol_error();
};

class protocol_not_supported : public general
{
public:
    protocol_not_supported();
};

class read_only_file_system : public general
{
public:
    read_only_file_system();
};

class resource_deadlock_would_occur : public general
{
public:
    resource_deadlock_would_occur();
};

class resource_unavailable_try_again : public general
{
public:
    resource_unavailable_try_again();
};

class result_out_of_range : public general
{
public:
    result_out_of_range();
};

class state_not_recoverable : public general
{
public:
    state_not_recoverable();
};

class stream_timeout : public general
{
public:
    stream_timeout();
};

class text_file_busy : public general
{
public:
    text_file_busy();
};

class timed_out : public general
{
public:
    timed_out();
};

class too_many_files_open_in_system : public general
{
public:
    too_many_files_open_in_system();
};

class too_many_files_open : public general
{
public:
    too_many_files_open();
};

class too_many_links : public general
{
public:
    too_many_links();
};

class too_many_symbolic_link_levels : public general
{
public:
    too_many_symbolic_link_levels();
};

class value_too_large : public general
{
public:
    value_too_large();
};

class wrong_protocol_type : public general
{
public:
    wrong_protocol_type();
};


} /* namespace exception */
} /* namespace linux */
} /* namespace exo */

#endif /* EXO_LINUX_EXCEPTION_HPP_INCLUDED */
