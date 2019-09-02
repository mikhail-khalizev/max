using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a338-562e3f18")]
        public void Method_100a_a338()
        {
            ii(0x100a_a338, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_a33d, 5); call(Definitions.sys_check_available_stack_size, 0xb_ba10); /* call 0x10165d52 */
            ii(0x100a_a342, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a343, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a344, 1); push(esi);                              /* push esi */
            ii(0x100a_a345, 1); push(edi);                              /* push edi */
            ii(0x100a_a346, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a347, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a349, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a34f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a352, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_a355, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a357, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a35a, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_a35d, 5); call(Definitions.my_dtor_0x101b_56fc, -0x2_1726); /* call 0x10088c3c */
            ii(0x100a_a362, 3); sub(eax, 0x28);                         /* sub eax, 0x28 */
            ii(0x100a_a365, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a368, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a36a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a36d, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_a370, 5); call(0x100a_a138, -0x23d);              /* call 0x100aa138 */
            ii(0x100a_a375, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x100a_a378, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a37b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a37d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a380, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_a383, 5); call(0x100a_a138, -0x250);              /* call 0x100aa138 */
            ii(0x100a_a388, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x100a_a38b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a38e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a390, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a393, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100a_a396, 5); call(0x100a_a030, -0x36b);              /* call 0x100aa030 */
            ii(0x100a_a39b, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x100a_a39e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a3a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a3a3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a3a6, 5); call(0x1009_b834, -0xeb77);             /* call 0x1009b834 */
            ii(0x100a_a3ab, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a3ae, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a3b1, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_a3b4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_a3b7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a3b9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a3ba, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a3bb, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a3bc, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a3bd, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a3be, 1); ret();                                  /* ret */
        }
    }
}
