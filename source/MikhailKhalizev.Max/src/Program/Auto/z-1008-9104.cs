using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9104-f88d3d42")]
        public void Method_1008_9104()
        {
            ii(0x1008_9104, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_9109, 5); call(Definitions.sys_check_available_stack_size, 0xd_cc44); /* call 0x10165d52 */
            ii(0x1008_910e, 1); push(ebx);                              /* push ebx */
            ii(0x1008_910f, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9110, 1); push(esi);                              /* push esi */
            ii(0x1008_9111, 1); push(edi);                              /* push edi */
            ii(0x1008_9112, 1); push(ebp);                              /* push ebp */
            ii(0x1008_9113, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9115, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_911b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_911e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_9121, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_9123, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9126, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1008_9129, 5); call(0x1008_8b04, -0x62a);              /* call 0x10088b04 */
            ii(0x1008_912e, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1008_9131, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_9134, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_9136, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9139, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1008_913c, 5); call(0x1008_8dcc, -0x375);              /* call 0x10088dcc */
            ii(0x1008_9141, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1008_9144, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_9147, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_9149, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_914c, 5); call(Definitions.my_dtor_0x101b_56fc, -0x515); /* call 0x10088c3c */
            ii(0x1008_9151, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_9154, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9157, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_915a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_915d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_915f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_9160, 1); pop(edi);                               /* pop edi */
            ii(0x1008_9161, 1); pop(esi);                               /* pop esi */
            ii(0x1008_9162, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9163, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9164, 1); ret();                                  /* ret */
        }
    }
}
