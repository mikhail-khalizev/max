using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_6202-c521c3f2")]
        public void Method_1012_6202()
        {
            ii(0x1012_6202, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_6207, 5); call(Definitions.sys_check_available_stack_size, 0x3_fb46); /* call 0x10165d52 */
            ii(0x1012_620c, 1); push(ebx);                              /* push ebx */
            ii(0x1012_620d, 1); push(ecx);                              /* push ecx */
            ii(0x1012_620e, 1); push(esi);                              /* push esi */
            ii(0x1012_620f, 1); push(edi);                              /* push edi */
            ii(0x1012_6210, 1); push(ebp);                              /* push ebp */
            ii(0x1012_6211, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_6213, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_6219, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_621c, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_621f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_6222, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_6225, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_6228, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_622b, 5); call(0x1012_5f31, -0x2ff);              /* call 0x10125f31 */
            ii(0x1012_6230, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_6233, 3); mov(dl, memb[ds, eax + 0x46]);          /* mov dl, [eax+0x46] */
            ii(0x1012_6236, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_6239, 3); mov(memb[ds, eax + 0xd], dl);           /* mov [eax+0xd], dl */
            ii(0x1012_623c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_623f, 3); mov(dl, memb[ds, eax + 0x47]);          /* mov dl, [eax+0x47] */
            ii(0x1012_6242, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_6245, 3); mov(memb[ds, eax + 0xe], dl);           /* mov [eax+0xe], dl */
            ii(0x1012_6248, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_624b, 3); mov(dl, memb[ds, eax + 0x48]);          /* mov dl, [eax+0x48] */
            ii(0x1012_624e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_6251, 3); mov(memb[ds, eax + 0xf], dl);           /* mov [eax+0xf], dl */
            ii(0x1012_6254, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_6257, 3); mov(dl, memb[ds, eax + 0x49]);          /* mov dl, [eax+0x49] */
            ii(0x1012_625a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_625d, 3); mov(memb[ds, eax + 0x10], dl);          /* mov [eax+0x10], dl */
            ii(0x1012_6260, 7); mov(memd[ss, ebp - 0xc], 0x11);         /* mov dword [ebp-0xc], 0x11 */
            ii(0x1012_6267, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_626a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_626c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_626d, 1); pop(edi);                               /* pop edi */
            ii(0x1012_626e, 1); pop(esi);                               /* pop esi */
            ii(0x1012_626f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_6270, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_6271, 1); ret();                                  /* ret */
        }
    }
}
