using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_54db-268a53eb")]
        public void Method_1014_54db()
        {
            ii(0x1014_54db, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1014_54e0, 5); call(Definitions.sys_check_available_stack_size, 0x2_086d); /* call 0x10165d52 */
            ii(0x1014_54e5, 1); push(esi);                              /* push esi */
            ii(0x1014_54e6, 1); push(edi);                              /* push edi */
            ii(0x1014_54e7, 1); push(ebp);                              /* push ebp */
            ii(0x1014_54e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_54ea, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_54f0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_54f3, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1014_54f6, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1014_54f9, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1014_54fc, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1014_54ff, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1014_5502, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5505, 5); call(0x1014_4f3c, -0x5ce);              /* call 0x10144f3c */
            ii(0x1014_550a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_550d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_5510, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_5513, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5516, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1014_5519, 5); call(Definitions.my_string_ctor, -0x3a36); /* call 0x10141ae8 */
            ii(0x1014_551e, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x1014_5521, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_5524, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_5527, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_552a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_552d, 7); mov(memd[ds, eax + 2], 0x101b_7228);    /* mov dword [eax+0x2], 0x101b7228 */
            ii(0x1014_5534, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_5537, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_553a, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1014_553d, 5); call(0x1014_2246, -0x32fc);             /* call 0x10142246 */
            ii(0x1014_5542, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5545, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_5548, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_554b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_554d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_554e, 1); pop(edi);                               /* pop edi */
            ii(0x1014_554f, 1); pop(esi);                               /* pop esi */
            ii(0x1014_5550, 1); ret();                                  /* ret */
        }
    }
}
