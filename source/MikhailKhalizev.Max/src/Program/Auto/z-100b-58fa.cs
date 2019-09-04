using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_58fa-626d4fe1")]
        public void Method_100b_58fa()
        {
            ii(0x100b_58fa, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_58ff, 5); call(Definitions.sys_check_available_stack_size, 0xb_044e); /* call 0x10165d52 */
            ii(0x100b_5904, 1); push(ebx);                              /* push ebx */
            ii(0x100b_5905, 1); push(ecx);                              /* push ecx */
            ii(0x100b_5906, 1); push(esi);                              /* push esi */
            ii(0x100b_5907, 1); push(edi);                              /* push edi */
            ii(0x100b_5908, 1); push(ebp);                              /* push ebp */
            ii(0x100b_5909, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_590b, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_5911, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_5914, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_5917, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_591a, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100b_591d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_5920, 5); call(0x1007_6d98, -0x3_eb8d);           /* call 0x10076d98 */
            ii(0x100b_5925, 2); test(al, al);                           /* test al, al */
            ii(0x100b_5927, 2); if(jz(0x100b_5943, 0x1a)) goto l_0x100b_5943; /* jz 0x100b5943 */
            ii(0x100b_5929, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_592b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_592e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5931, 5); call(0x1007_6630, -0x3_f306);           /* call 0x10076630 */
            ii(0x100b_5936, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_5939, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_593e, 5); call(0x100a_5e27, -0xfb1c);             /* call 0x100a5e27 */
        l_0x100b_5943:
            ii(0x100b_5943, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5945, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_5946, 1); pop(edi);                               /* pop edi */
            ii(0x100b_5947, 1); pop(esi);                               /* pop esi */
            ii(0x100b_5948, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_5949, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_594a, 1); ret();                                  /* ret */
        }
    }
}
