#include <errno.h>
#include <string.h> // strerror
#include <exo/linux/exception.hpp>


namespace exo {
namespace linux {
namespace exception {


void throw_errno()
{
    throw_exception(errno);
}

void throw_exception(int err)
{
    switch(err)
    {
    /* @note See boost::system::errc */
    case EAFNOSUPPORT:
        throw address_family_not_supported();
        break;
    case EADDRINUSE:
        throw address_in_use();
        break;
    case EADDRNOTAVAIL:
        throw address_not_available();
        break;
    case EISCONN:
        throw already_connected();
        break;
    case E2BIG:
        throw argument_list_too_long();
        break;
    case EDOM:
        throw argument_out_of_domain();
        break;
    case EFAULT:
        throw bad_address();
        break;
    case EBADF:
        throw bad_file_descriptor();
        break;
    case EBADMSG:
        throw bad_message();
        break;
    case EPIPE:
        throw broken_pipe();
        break;
    case ECONNABORTED:
        throw connection_aborted();
        break;
    case EALREADY:
        throw connection_already_in_progress();
        break;
    case ECONNREFUSED:
        throw connection_refused();
        break;
    case ECONNRESET:
        throw connection_reset();
        break;
    case EXDEV:
        throw cross_device_link();
        break;
    case EDESTADDRREQ:
        throw destination_address_required();
        break;
    case EBUSY:
        throw device_or_resource_busy();
        break;
    case ENOTEMPTY:
        throw directory_not_empty();
        break;
    case ENOEXEC:
        throw executable_format_error();
        break;
    case EEXIST:
        throw file_exists();
        break;
    case EFBIG:
        throw file_too_large();
        break;
    case ENAMETOOLONG:
        throw filename_too_long();
        break;
    case ENOSYS:
        throw function_not_supported();
        break;
    case EHOSTUNREACH:
        throw host_unreachable();
        break;
    case EIDRM:
        throw identifier_removed();
        break;
    case EILSEQ:
        throw illegal_byte_sequence();
        break;
    case ENOTTY:
        throw inappropriate_io_control_operation();
        break;
    case EINTR:
        throw interrupted();
        break;
    case EINVAL:
        throw invalid_argument();
        break;
    case ESPIPE:
        throw invalid_seek();
        break;
    case EIO:
        throw io_error();
        break;
    case EISDIR:
        throw is_a_directory();
        break;
    case EMSGSIZE:
        throw message_size();
        break;
    case ENETDOWN:
        throw network_down();
        break;
    case ENETRESET:
        throw network_reset();
        break;
    case ENETUNREACH:
        throw network_unreachable();
        break;
    case ENOBUFS:
        throw no_buffer_space();
        break;
    case ECHILD:
        throw no_child_process();
        break;
    case ENOLINK:
        throw no_link();
        break;
    case ENOLCK:
        throw no_lock_available();
        break;
    case ENODATA:
        throw no_message_available();
        break;
    case ENOMSG:
        throw no_message();
        break;
    case ENOPROTOOPT:
        throw no_protocol_option();
        break;
    case ENOSPC:
        throw no_space_on_device();
        break;
    case ENOSR:
        throw no_stream_resources();
        break;
    case ENXIO:
        throw no_such_device_or_address();
        break;
    case ENODEV:
        throw no_such_device();
        break;
    case ENOENT:
        throw no_such_file_or_directory();
        break;
    case ESRCH:
        throw no_such_process();
        break;
    case ENOTDIR:
        throw not_a_directory();
        break;
    case ENOTSOCK:
        throw not_a_socket();
        break;
    case ENOSTR:
        throw not_a_stream();
        break;
    case ENOTCONN:
        throw not_connected();
        break;
    case ENOMEM:
        throw not_enough_memory();
        break;
    case ECANCELED:
        throw operation_canceled();
        break;
    case EINPROGRESS:
        throw operation_in_progress();
        break;
    case EPERM:
        throw operation_not_permitted();
        break;

    case EOPNOTSUPP:
        throw operation_not_supported();
        break;
#if EOPNOTSUPP != ENOTSUP
    case ENOTSUP:
        throw not_supported();
        break;
#endif

    case EAGAIN:
        throw resource_unavailable_try_again();
        break;
#if EAGAIN != EWOULDBLOCK
    case EWOULDBLOCK:
        throw operation_would_block();
        break;
#endif

    case EOWNERDEAD:
        throw owner_dead();
        break;
    case EACCES:
        throw permission_denied();
        break;
    case EPROTO:
        throw protocol_error();
        break;
    case EPROTONOSUPPORT:
        throw protocol_not_supported();
        break;
    case EROFS:
        throw read_only_file_system();
        break;
    case EDEADLK:
        throw resource_deadlock_would_occur();
        break;
    case ERANGE:
        throw result_out_of_range();
        break;
    case ENOTRECOVERABLE:
        throw state_not_recoverable();
        break;
    case ETIME:
        throw stream_timeout();
        break;
    case ETXTBSY:
        throw text_file_busy();
        break;
    case ETIMEDOUT:
        throw timed_out();
        break;
    case ENFILE:
        throw too_many_files_open_in_system();
        break;
    case EMFILE:
        throw too_many_files_open();
        break;
    case EMLINK:
        throw too_many_links();
        break;
    case ELOOP:
        throw too_many_symbolic_link_levels();
        break;
    case EOVERFLOW:
        throw value_too_large();
        break;
    case EPROTOTYPE:
        throw wrong_protocol_type();
        break;
    default:
        throw general(err);
        break;
    }
}


general::general(int err_)
: err(err_)
{}

const char * general::what() const throw()
{
    return strerror(err);
}


address_family_not_supported::address_family_not_supported()
: general(EAFNOSUPPORT)
{}

address_in_use::address_in_use()
: general(EADDRINUSE)
{}

address_not_available::address_not_available()
: general(EADDRNOTAVAIL)
{}

already_connected::already_connected()
: general(EISCONN)
{}

argument_list_too_long::argument_list_too_long()
: general(E2BIG)
{}

argument_out_of_domain::argument_out_of_domain()
: general(EDOM)
{}

bad_address::bad_address()
: general(EFAULT)
{}

bad_file_descriptor::bad_file_descriptor()
: general(EBADF)
{}

bad_message::bad_message()
: general(EBADMSG)
{}

broken_pipe::broken_pipe()
: general(EPIPE)
{}

connection_aborted::connection_aborted()
: general(ECONNABORTED)
{}

connection_already_in_progress::connection_already_in_progress()
: general(EALREADY)
{}

connection_refused::connection_refused()
: general(ECONNREFUSED)
{}

connection_reset::connection_reset()
: general(ECONNRESET)
{}

cross_device_link::cross_device_link()
: general(EXDEV)
{}

destination_address_required::destination_address_required()
: general(EDESTADDRREQ)
{}

device_or_resource_busy::device_or_resource_busy()
: general(EBUSY)
{}

directory_not_empty::directory_not_empty()
: general(ENOTEMPTY)
{}

executable_format_error::executable_format_error()
: general(ENOEXEC)
{}

file_exists::file_exists()
: general(EEXIST)
{}

file_too_large::file_too_large()
: general(EFBIG)
{}

filename_too_long::filename_too_long()
: general(ENAMETOOLONG)
{}

function_not_supported::function_not_supported()
: general(ENOSYS)
{}

host_unreachable::host_unreachable()
: general(EHOSTUNREACH)
{}

identifier_removed::identifier_removed()
: general(EIDRM)
{}

illegal_byte_sequence::illegal_byte_sequence()
: general(EILSEQ)
{}

inappropriate_io_control_operation::inappropriate_io_control_operation()
: general(ENOTTY)
{}

interrupted::interrupted()
: general(EINTR)
{}

invalid_argument::invalid_argument()
: general(EINVAL)
{}

invalid_seek::invalid_seek()
: general(ESPIPE)
{}

io_error::io_error()
: general(EIO)
{}

is_a_directory::is_a_directory()
: general(EISDIR)
{}

message_size::message_size()
: general(EMSGSIZE)
{}

network_down::network_down()
: general(ENETDOWN)
{}

network_reset::network_reset()
: general(ENETRESET)
{}

network_unreachable::network_unreachable()
: general(ENETUNREACH)
{}

no_buffer_space::no_buffer_space()
: general(ENOBUFS)
{}

no_child_process::no_child_process()
: general(ECHILD)
{}

no_link::no_link()
: general(ENOLINK)
{}

no_lock_available::no_lock_available()
: general(ENOLCK)
{}

no_message_available::no_message_available()
: general(ENODATA)
{}

no_message::no_message()
: general(ENOMSG)
{}

no_protocol_option::no_protocol_option()
: general(ENOPROTOOPT)
{}

no_space_on_device::no_space_on_device()
: general(ENOSPC)
{}

no_stream_resources::no_stream_resources()
: general(ENOSR)
{}

no_such_device_or_address::no_such_device_or_address()
: general(ENXIO)
{}

no_such_device::no_such_device()
: general(ENODEV)
{}

no_such_file_or_directory::no_such_file_or_directory()
: general(ENOENT)
{}

no_such_process::no_such_process()
: general(ESRCH)
{}

not_a_directory::not_a_directory()
: general(ENOTDIR)
{}

not_a_socket::not_a_socket()
: general(ENOTSOCK)
{}

not_a_stream::not_a_stream()
: general(ENOSTR)
{}

not_connected::not_connected()
: general(ENOTCONN)
{}

not_enough_memory::not_enough_memory()
: general(ENOMEM)
{}

not_supported::not_supported()
: general(ENOTSUP)
{}

operation_canceled::operation_canceled()
: general(ECANCELED)
{}

operation_in_progress::operation_in_progress()
: general(EINPROGRESS)
{}

operation_not_permitted::operation_not_permitted()
: general(EPERM)
{}

operation_not_supported::operation_not_supported()
: general(EOPNOTSUPP)
{}

operation_would_block::operation_would_block()
: general(EWOULDBLOCK)
{}

owner_dead::owner_dead()
: general(EOWNERDEAD)
{}

permission_denied::permission_denied()
: general(EACCES)
{}

protocol_error::protocol_error()
: general(EPROTO)
{}

protocol_not_supported::protocol_not_supported()
: general(EPROTONOSUPPORT)
{}

read_only_file_system::read_only_file_system()
: general(EROFS)
{}

resource_deadlock_would_occur::resource_deadlock_would_occur()
: general(EDEADLK)
{}

resource_unavailable_try_again::resource_unavailable_try_again()
: general(EAGAIN)
{}

result_out_of_range::result_out_of_range()
: general(ERANGE)
{}

state_not_recoverable::state_not_recoverable()
: general(ENOTRECOVERABLE)
{}

stream_timeout::stream_timeout()
: general(ETIME)
{}

text_file_busy::text_file_busy()
: general(ETXTBSY)
{}

timed_out::timed_out()
: general(ETIMEDOUT)
{}

too_many_files_open_in_system::too_many_files_open_in_system()
: general(ENFILE)
{}

too_many_files_open::too_many_files_open()
: general(EMFILE)
{}

too_many_links::too_many_links()
: general(EMLINK)
{}

too_many_symbolic_link_levels::too_many_symbolic_link_levels()
: general(ELOOP)
{}

value_too_large::value_too_large()
: general(EOVERFLOW)
{}

wrong_protocol_type::wrong_protocol_type()
: general(EPROTOTYPE)
{}


} /* namespace exception */
} /* namespace linux */
} /* namespace exo */
