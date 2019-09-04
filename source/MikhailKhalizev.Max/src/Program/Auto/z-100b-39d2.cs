using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_39d2-5cbd67ee")]
        public void Method_100b_39d2()
        {
            ii(0x100b_39d2, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_39d7, 5); call(Definitions.sys_check_available_stack_size, 0xb_2376); /* call 0x10165d52 */
            ii(0x100b_39dc, 1); push(ebx);                              /* push ebx */
            ii(0x100b_39dd, 1); push(ecx);                              /* push ecx */
            ii(0x100b_39de, 1); push(esi);                              /* push esi */
            ii(0x100b_39df, 1); push(edi);                              /* push edi */
            ii(0x100b_39e0, 1); push(ebp);                              /* push ebp */
            ii(0x100b_39e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_39e3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_39e9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_39ec, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_39ef, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_39f2, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100b_39f5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_39f8, 5); call(0x1008_b4b4, -0x2_8549);           /* call 0x1008b4b4 */
            ii(0x100b_39fd, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x100b_3a00, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100b_3a03, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3a05, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_3a06, 1); pop(edi);                               /* pop edi */
            ii(0x100b_3a07, 1); pop(esi);                               /* pop esi */
            ii(0x100b_3a08, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_3a09, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_3a0a, 1); ret();                                  /* ret */
        }
    }
}
