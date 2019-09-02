using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_409c-714d67c1")]
        public void Method_100c_409c()
        {
            ii(0x100c_409c, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_40a1, 5); call(Definitions.sys_check_available_stack_size, 0xa_1cac); /* call 0x10165d52 */
            ii(0x100c_40a6, 1); push(ebx);                              /* push ebx */
            ii(0x100c_40a7, 1); push(ecx);                              /* push ecx */
            ii(0x100c_40a8, 1); push(edx);                              /* push edx */
            ii(0x100c_40a9, 1); push(esi);                              /* push esi */
            ii(0x100c_40aa, 1); push(edi);                              /* push edi */
            ii(0x100c_40ab, 1); push(ebp);                              /* push ebp */
            ii(0x100c_40ac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_40ae, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_40b4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_40b7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_40ba, 3); mov(al, memb[ds, eax + 2]);             /* mov al, [eax+0x2] */
            ii(0x100c_40bd, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100c_40c0, 2); jmp(0x100c_4121, 0x5f); goto l_0x100c_4121; /* jmp 0x100c4121 */
        l_0x100c_40c2:
            ii(0x100c_40c2, 5); call(/* sys */ 0x1016_5e9b, 0xa_1dd4);  /* call 0x10165e9b */
            ii(0x100c_40c7, 3); imul(eax, eax, 6);                      /* imul eax, eax, 0x6 */
            ii(0x100c_40ca, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_40cd, 3); lea(edx, memd[ds, eax + 7]);            /* lea edx, [eax+0x7] */
            ii(0x100c_40d0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_40d3, 4); mov(memw[ds, eax + 5], dx);             /* mov [eax+0x5], dx */
            ii(0x100c_40d7, 5); jmp(0x100c_4159, 0x7d); goto l_0x100c_4159; /* jmp 0x100c4159 */
        l_0x100c_40dc:
            ii(0x100c_40dc, 5); call(/* sys */ 0x1016_5e9b, 0xa_1dba);  /* call 0x10165e9b */
            ii(0x100c_40e1, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_40e4, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_40e7, 3); lea(edx, memd[ds, eax + 4]);            /* lea edx, [eax+0x4] */
            ii(0x100c_40ea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_40ed, 4); mov(memw[ds, eax + 5], dx);             /* mov [eax+0x5], dx */
            ii(0x100c_40f1, 5); jmp(0x100c_4159, 0x63); goto l_0x100c_4159; /* jmp 0x100c4159 */
        l_0x100c_40f6:
            ii(0x100c_40f6, 5); call(/* sys */ 0x1016_5e9b, 0xa_1da0);  /* call 0x10165e9b */
            ii(0x100c_40fb, 3); lea(eax, memd[ds, eax + eax * 2]);      /* lea eax, [eax+eax*2] */
            ii(0x100c_40fe, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_4101, 3); lea(edx, memd[ds, eax + 1]);            /* lea edx, [eax+0x1] */
            ii(0x100c_4104, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_4107, 4); mov(memw[ds, eax + 5], dx);             /* mov [eax+0x5], dx */
            ii(0x100c_410b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_410e, 6); mov(memw[ds, eax + 5], 5);              /* mov word [eax+0x5], 0x5 */
            ii(0x100c_4114, 2); jmp(0x100c_4159, 0x43); goto l_0x100c_4159; /* jmp 0x100c4159 */
        l_0x100c_4116:
            ii(0x100c_4116, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_4119, 6); mov(memw[ds, eax + 5], 0);              /* mov word [eax+0x5], 0x0 */
            ii(0x100c_411f, 2); jmp(0x100c_4159, 0x38); goto l_0x100c_4159; /* jmp 0x100c4159 */
        l_0x100c_4121:
            ii(0x100c_4121, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100c_4124, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100c_4127, 4); cmp(memb[ss, ebp - 0xc], 3);            /* cmp byte [ebp-0xc], 0x3 */
            ii(0x100c_412b, 2); if(jb(0x100c_4145, 0x18)) goto l_0x100c_4145; /* jb 0x100c4145 */
            ii(0x100c_412d, 4); cmp(memb[ss, ebp - 0xc], 4);            /* cmp byte [ebp-0xc], 0x4 */
            ii(0x100c_4131, 2); if(jbe(0x100c_40c2, -0x71)) goto l_0x100c_40c2; /* jbe 0x100c40c2 */
            ii(0x100c_4133, 4); cmp(memb[ss, ebp - 0xc], 6);            /* cmp byte [ebp-0xc], 0x6 */
            ii(0x100c_4137, 2); if(jbe(0x100c_40f6, -0x43)) goto l_0x100c_40f6; /* jbe 0x100c40f6 */
            ii(0x100c_4139, 4); cmp(memb[ss, ebp - 0xc], 9);            /* cmp byte [ebp-0xc], 0x9 */
            ii(0x100c_413d, 2); if(jbe(0x100c_40dc, -0x63)) goto l_0x100c_40dc; /* jbe 0x100c40dc */
            ii(0x100c_413f, 2); jmp(0x100c_4116, -0x2b); goto l_0x100c_4116; /* jmp 0x100c4116 */
        //  ii(0x100c_4141, 2); jmp(0x100c_4116, -0x2d); goto l_0x100c_4116; /* jmp 0x100c4116 */
        //  ii(0x100c_4143, 2); jmp(0x100c_4116, -0x2f); goto l_0x100c_4116; /* jmp 0x100c4116 */
        l_0x100c_4145:
            ii(0x100c_4145, 4); cmp(memb[ss, ebp - 0xc], 1);            /* cmp byte [ebp-0xc], 0x1 */
            ii(0x100c_4149, 2); if(jb(0x100c_4157, 0xc)) goto l_0x100c_4157; /* jb 0x100c4157 */
            ii(0x100c_414b, 4); cmp(memb[ss, ebp - 0xc], 1);            /* cmp byte [ebp-0xc], 0x1 */
            ii(0x100c_414f, 6); if(jbe(0x100c_40c2, -0x93)) goto l_0x100c_40c2; /* jbe 0x100c40c2 */
            ii(0x100c_4155, 2); jmp(0x100c_40dc, -0x7b); goto l_0x100c_40dc; /* jmp 0x100c40dc */
        l_0x100c_4157:
            ii(0x100c_4157, 2); jmp(0x100c_4116, -0x43); goto l_0x100c_4116; /* jmp 0x100c4116 */
        l_0x100c_4159:
            ii(0x100c_4159, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_415b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_415c, 1); pop(edi);                               /* pop edi */
            ii(0x100c_415d, 1); pop(esi);                               /* pop esi */
            ii(0x100c_415e, 1); pop(edx);                               /* pop edx */
            ii(0x100c_415f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_4160, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_4161, 1); ret();                                  /* ret */
        }
    }
}
