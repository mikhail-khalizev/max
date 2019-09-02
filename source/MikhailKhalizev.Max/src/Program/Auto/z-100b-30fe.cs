using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_30fe-6488eff8")]
        public void Method_100b_30fe()
        {
            ii(0x100b_30fe, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_3103, 5); call(Definitions.sys_check_available_stack_size, 0xb_2c4a); /* call 0x10165d52 */
            ii(0x100b_3108, 1); push(ebx);                              /* push ebx */
            ii(0x100b_3109, 1); push(ecx);                              /* push ecx */
            ii(0x100b_310a, 1); push(esi);                              /* push esi */
            ii(0x100b_310b, 1); push(edi);                              /* push edi */
            ii(0x100b_310c, 1); push(ebp);                              /* push ebp */
            ii(0x100b_310d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_310f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_3115, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_3118, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_311b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_311e, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100b_3121, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_3124, 5); call(0x1008_b4b4, -0x2_7c75);           /* call 0x1008b4b4 */
            ii(0x100b_3129, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x100b_312c, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100b_312f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3131, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_3132, 1); pop(edi);                               /* pop edi */
            ii(0x100b_3133, 1); pop(esi);                               /* pop esi */
            ii(0x100b_3134, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_3135, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_3136, 1); ret();                                  /* ret */
        }
    }
}
