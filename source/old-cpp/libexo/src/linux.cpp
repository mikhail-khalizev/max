#include <exo/linux.hpp>


namespace exo {
namespace linux {

#if 0

void sem_remover::operator()(pointer id) const
{
    if (id < 0)
        return;

    try
    {
        int ok = semctl(id, 0, IPC_RMID);
        throw_assert_os(ok == 0);
    }
    _catch_to_log_
}

void munmaper::operator()(pointer sp) const
{
    if (sp.IsEmpty())
        return;

    try
    {
        int ok = munmap(sp.Data(), sp.Size());
        throw_assert_os(ok == 0);
    }
    _catch_to_log_
}

#endif

} /* namespace linux */
} /* namespace exo */
