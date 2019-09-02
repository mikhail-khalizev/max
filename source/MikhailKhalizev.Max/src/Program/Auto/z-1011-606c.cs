using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_606c-981b9e")]
        public void Method_1011_606c()
        {
            ii(0x1011_606c, 5); push(0x30);                             /* push 0x30 */
            ii(0x1011_6071, 5); call(Definitions.sys_check_available_stack_size, 0x4_fcdc); /* call 0x10165d52 */
            ii(0x1011_6076, 1); push(ebx);                              /* push ebx */
            ii(0x1011_6077, 1); push(ecx);                              /* push ecx */
            ii(0x1011_6078, 1); push(edx);                              /* push edx */
            ii(0x1011_6079, 1); push(esi);                              /* push esi */
            ii(0x1011_607a, 1); push(edi);                              /* push edi */
            ii(0x1011_607b, 1); push(ebp);                              /* push ebp */
            ii(0x1011_607c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_607e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_6084, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_6087, 5); call(0x100f_a9fd, -0x1_b68f);           /* call 0x100fa9fd */
            ii(0x1011_608c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_608f, 5); call(0x100f_f562, -0x1_6b32);           /* call 0x100ff562 */
            ii(0x1011_6094, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x1011_6099, 5); call(0x100e_883d, -0x2_d861);           /* call 0x100e883d */
            ii(0x1011_609e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_60a1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_60a4, 7); mov(memd[ds, eax + 4], 0xffff_ffff);    /* mov dword [eax+0x4], 0xffffffff */
            ii(0x1011_60ab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_60ae, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x1011_60b1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_60b4, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1011_60b6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_60b9, 7); mov(memd[ds, eax + 0xc], 0xffff_ffff);  /* mov dword [eax+0xc], 0xffffffff */
            ii(0x1011_60c0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_60c3, 3); mov(edx, memd[ds, eax + 0xc]);          /* mov edx, [eax+0xc] */
            ii(0x1011_60c6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_60c9, 3); mov(memd[ds, eax + 8], edx);            /* mov [eax+0x8], edx */
            ii(0x1011_60cc, 7); mov(memb[ds, 0x101c_391d], 0);          /* mov byte [0x101c391d], 0x0 */
            ii(0x1011_60d3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_60d5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_60d6, 1); pop(edi);                               /* pop edi */
            ii(0x1011_60d7, 1); pop(esi);                               /* pop esi */
            ii(0x1011_60d8, 1); pop(edx);                               /* pop edx */
            ii(0x1011_60d9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_60da, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_60db, 1); ret();                                  /* ret */
        }
    }
}
