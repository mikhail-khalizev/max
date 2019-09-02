using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3e0b-42caccd7")]
        public void Method_100b_3e0b()
        {
            ii(0x100b_3e0b, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_3e10, 5); call(Definitions.sys_check_available_stack_size, 0xb_1f3d); /* call 0x10165d52 */
            ii(0x100b_3e15, 1); push(ebx);                              /* push ebx */
            ii(0x100b_3e16, 1); push(ecx);                              /* push ecx */
            ii(0x100b_3e17, 1); push(esi);                              /* push esi */
            ii(0x100b_3e18, 1); push(edi);                              /* push edi */
            ii(0x100b_3e19, 1); push(ebp);                              /* push ebp */
            ii(0x100b_3e1a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3e1c, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_3e22, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_3e25, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_3e28, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_3e2b, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100b_3e2e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_3e31, 5); call(0x1007_6d98, -0x3_d09e);           /* call 0x10076d98 */
            ii(0x100b_3e36, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3e38, 2); if(jz(0x100b_3e7b, 0x41)) goto l_0x100b_3e7b; /* jz 0x100b3e7b */
            ii(0x100b_3e3a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3e3c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_3e3f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3e42, 5); call(0x1007_6630, -0x3_d817);           /* call 0x10076630 */
            ii(0x100b_3e47, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3e49, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_3e4c, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100b_3e4f, 5); call(0x1009_c8f8, -0x1_755c);           /* call 0x1009c8f8 */
            ii(0x100b_3e54, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3e56, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_3e59, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_3e5c, 5); call(0x1008_afe4, -0x2_8e7d);           /* call 0x1008afe4 */
            ii(0x100b_3e61, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3e63, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_3e66, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_3e69, 5); call(0x1007_6630, -0x3_d83e);           /* call 0x10076630 */
            ii(0x100b_3e6e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_3e71, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_3e76, 5); call(0x100a_5e27, -0xe054);             /* call 0x100a5e27 */
        l_0x100b_3e7b:
            ii(0x100b_3e7b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3e7d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_3e7e, 1); pop(edi);                               /* pop edi */
            ii(0x100b_3e7f, 1); pop(esi);                               /* pop esi */
            ii(0x100b_3e80, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_3e81, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_3e82, 1); ret();                                  /* ret */
        }
    }
}
