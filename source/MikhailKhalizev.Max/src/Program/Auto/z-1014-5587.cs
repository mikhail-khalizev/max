using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5587-e5de125d")]
        public void Method_1014_5587()
        {
            ii(0x1014_5587, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1014_558c, 5); call(Definitions.sys_check_available_stack_size, 0x2_07c1); /* call 0x10165d52 */
            ii(0x1014_5591, 1); push(esi);                              /* push esi */
            ii(0x1014_5592, 1); push(edi);                              /* push edi */
            ii(0x1014_5593, 1); push(ebp);                              /* push ebp */
            ii(0x1014_5594, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5596, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_559c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_559f, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1014_55a2, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1014_55a5, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1014_55a8, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_55ab, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1014_55ae, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_55b1, 5); call(0x1014_4f3c, -0x67a);              /* call 0x10144f3c */
            ii(0x1014_55b6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_55b9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_55bc, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_55bf, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_55c2, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1014_55c5, 5); call(0x1014_806c, 0x2aa2);              /* call 0x1014806c */
            ii(0x1014_55ca, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x1014_55cd, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_55d0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_55d3, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_55d6, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_55d9, 7); mov(memd[ds, eax + 0x2], 0x101b_720c);  /* mov dword [eax+0x2], 0x101b720c */
            ii(0x1014_55e0, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_55e3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_55e6, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1014_55e9, 5); call(0x1014_7ff0, 0x2a02);              /* call 0x10147ff0 */
            ii(0x1014_55ee, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_55f1, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_55f4, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_55f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_55f9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_55fa, 1); pop(edi);                               /* pop edi */
            ii(0x1014_55fb, 1); pop(esi);                               /* pop esi */
            ii(0x1014_55fc, 1); ret();                                  /* ret */
        }
    }
}
