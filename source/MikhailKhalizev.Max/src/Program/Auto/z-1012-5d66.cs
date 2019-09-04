using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5d66-96e4de13")]
        public void Method_1012_5d66()
        {
            ii(0x1012_5d66, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_5d6b, 5); call(Definitions.sys_check_available_stack_size, 0x3_ffe2); /* call 0x10165d52 */
            ii(0x1012_5d70, 1); push(ebx);                              /* push ebx */
            ii(0x1012_5d71, 1); push(ecx);                              /* push ecx */
            ii(0x1012_5d72, 1); push(esi);                              /* push esi */
            ii(0x1012_5d73, 1); push(edi);                              /* push edi */
            ii(0x1012_5d74, 1); push(ebp);                              /* push ebp */
            ii(0x1012_5d75, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5d77, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_5d7d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_5d80, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_5d83, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_5d86, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1012_5d89, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_5d8c, 3); mov(dl, memb[ds, eax + 61]);            /* mov dl, [eax+0x3d] */
            ii(0x1012_5d8f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_5d92, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
            ii(0x1012_5d94, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_5d97, 3); mov(dl, memb[ds, eax + 62]);            /* mov dl, [eax+0x3e] */
            ii(0x1012_5d9a, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_5d9d, 3); mov(memb[ds, eax + 1], dl);             /* mov [eax+0x1], dl */
            ii(0x1012_5da0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_5da3, 3); mov(dl, memb[ds, eax + 63]);            /* mov dl, [eax+0x3f] */
            ii(0x1012_5da6, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_5da9, 3); mov(memb[ds, eax + 2], dl);             /* mov [eax+0x2], dl */
            ii(0x1012_5dac, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_5daf, 3); mov(dl, memb[ds, eax + 64]);            /* mov dl, [eax+0x40] */
            ii(0x1012_5db2, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_5db5, 3); mov(memb[ds, eax + 3], dl);             /* mov [eax+0x3], dl */
            ii(0x1012_5db8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_5dbb, 3); mov(dl, memb[ds, eax + 91]);            /* mov dl, [eax+0x5b] */
            ii(0x1012_5dbe, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_5dc1, 3); mov(memb[ds, eax + 4], dl);             /* mov [eax+0x4], dl */
            ii(0x1012_5dc4, 7); mov(memd[ss, ebp - 12], 5);             /* mov dword [ebp-0xc], 0x5 */
            ii(0x1012_5dcb, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_5dce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5dd0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_5dd1, 1); pop(edi);                               /* pop edi */
            ii(0x1012_5dd2, 1); pop(esi);                               /* pop esi */
            ii(0x1012_5dd3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_5dd4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_5dd5, 1); ret();                                  /* ret */
        }
    }
}
