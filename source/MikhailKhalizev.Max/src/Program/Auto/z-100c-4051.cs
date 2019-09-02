using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_4051-95ec3b21")]
        public void Method_100c_4051()
        {
            ii(0x100c_4051, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_4056, 5); call(Definitions.sys_check_available_stack_size, 0xa_1cf7); /* call 0x10165d52 */
            ii(0x100c_405b, 1); push(ebx);                              /* push ebx */
            ii(0x100c_405c, 1); push(ecx);                              /* push ecx */
            ii(0x100c_405d, 1); push(edx);                              /* push edx */
            ii(0x100c_405e, 1); push(esi);                              /* push esi */
            ii(0x100c_405f, 1); push(edi);                              /* push edi */
            ii(0x100c_4060, 1); push(ebp);                              /* push ebp */
            ii(0x100c_4061, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_4063, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100c_4069, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_406c, 5); call(/* sys */ 0x1016_5e9b, 0xa_1e2a);  /* call 0x10165e9b */
            ii(0x100c_4071, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_4074, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_4077, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_4079, 5); call(/* sys */ 0x1016_5e9b, 0xa_1e1d);  /* call 0x10165e9b */
            ii(0x100c_407e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_4081, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_4084, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x100c_4087, 3); add(edx, 2);                            /* add edx, 0x2 */
            ii(0x100c_408a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_408c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_408f, 4); mov(memw[ds, eax + 3], dx);             /* mov [eax+0x3], dx */
            ii(0x100c_4093, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_4095, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_4096, 1); pop(edi);                               /* pop edi */
            ii(0x100c_4097, 1); pop(esi);                               /* pop esi */
            ii(0x100c_4098, 1); pop(edx);                               /* pop edx */
            ii(0x100c_4099, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_409a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_409b, 1); ret();                                  /* ret */
        }
    }
}
