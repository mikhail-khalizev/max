using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f78c-77963463")]
        public void Method_1014_f78c()
        {
            ii(0x1014_f78c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_f791, 5); call(Definitions.sys_check_available_stack_size, 0x1_65bc); /* call 0x10165d52 */
            ii(0x1014_f796, 1); push(ebx);                              /* push ebx */
            ii(0x1014_f797, 1); push(ecx);                              /* push ecx */
            ii(0x1014_f798, 1); push(edx);                              /* push edx */
            ii(0x1014_f799, 1); push(esi);                              /* push esi */
            ii(0x1014_f79a, 1); push(edi);                              /* push edi */
            ii(0x1014_f79b, 1); push(ebp);                              /* push ebp */
            ii(0x1014_f79c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_f79e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_f7a4, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_f7a7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f7aa, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x1014_f7ad, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_f7b0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f7b3, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1014_f7b6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_f7bb, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x1014_f7c1, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1014_f7c6, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1014_f7c8, 5); call(0x100d_fd2c, -0x6_faa1);           /* call 0x100dfd2c */
            ii(0x1014_f7cd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_f7cf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_f7d2, 5); call(0x1007_6800, -0xd_8fd7);           /* call 0x10076800 */
            ii(0x1014_f7d7, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x1014_f7da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f7dd, 5); call(0x1014_edfa, -0x9e8);              /* call 0x1014edfa */
            ii(0x1014_f7e2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_f7e5, 5); call(0x1007_6730, -0xd_90ba);           /* call 0x10076730 */
            ii(0x1014_f7ea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_f7ec, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f7ef, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_f7f2, 5); call(0x1007_6730, -0xd_90c7);           /* call 0x10076730 */
            ii(0x1014_f7f7, 3); mov(dl, memb[ds, edx + 0xa]);           /* mov dl, [edx+0xa] */
            ii(0x1014_f7fa, 3); sub(dl, memb[ds, eax + 0xa]);           /* sub dl, [eax+0xa] */
            ii(0x1014_f7fd, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1014_f7ff, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_f802, 3); add(memb[ds, edx + 0x4d], al);          /* add [edx+0x4d], al */
            ii(0x1014_f805, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f808, 5); call(0x1016_15c9, 0x1_1dbc);            /* call 0x101615c9 */
            ii(0x1014_f80d, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x1014_f810, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f813, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_f816, 5); call(0x1015_5280, 0x5a65);              /* call 0x10155280 */
            ii(0x1014_f81b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_f820, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f823, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_f826, 5); call(0x1007_6730, -0xd_90fb);           /* call 0x10076730 */
            ii(0x1014_f82b, 5); call(0x100c_b7b4, -0x8_407c);           /* call 0x100cb7b4 */
            ii(0x1014_f830, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_f835, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f838, 5); call(0x1007_1838, -0xd_e005);           /* call 0x10071838 */
            ii(0x1014_f83d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_f83f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_f842, 5); call(0x1007_65d0, -0xd_9277);           /* call 0x100765d0 */
            ii(0x1014_f847, 5); call(0x1007_1838, -0xd_e014);           /* call 0x10071838 */
            ii(0x1014_f84c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_f84e, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_f851, 5); call(0x1007_5f2c, -0xd_992a);           /* call 0x10075f2c */
            ii(0x1014_f856, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_f858, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_f85b, 5); call(0x1007_5eec, -0xd_9974);           /* call 0x10075eec */
            ii(0x1014_f860, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_f862, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_f863, 1); pop(edi);                               /* pop edi */
            ii(0x1014_f864, 1); pop(esi);                               /* pop esi */
            ii(0x1014_f865, 1); pop(edx);                               /* pop edx */
            ii(0x1014_f866, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_f867, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_f868, 1); ret();                                  /* ret */
        }
    }
}
