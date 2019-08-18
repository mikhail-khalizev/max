using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_3020-16b8e44e")]
        public void Method_100e_3020()
        {
            ii(0x100e_3020, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100e_3025, 5); calld(Definitions.sys_check_available_stack_size, 0x8_2d28); /* call 0x10165d52 */
            ii(0x100e_302a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_302b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_302c, 1); pushd(esi);                             /* push esi */
            ii(0x100e_302d, 1); pushd(edi);                             /* push edi */
            ii(0x100e_302e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_302f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_3031, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100e_3037, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_303a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_303d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_3040, 5); calld(0x1007_623c, -0x6_ce09);          /* call 0x1007623c */
            ii(0x100e_3045, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_3047, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_304a, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100e_304d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_3050, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_3053, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100e_3056, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_305b, 6); imul(ecx, eax, 0x247);                  /* imul ecx, eax, 0x247 */
            ii(0x100e_3061, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100e_3066, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100e_3068, 5); calld(0x100d_fd2c, -0x3341);            /* call 0x100dfd2c */
            ii(0x100e_306d, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100e_306f, 2); if(jzd(0x100e_307a, 0x9)) goto l_0x100e_307a; /* jz 0x100e307a */
            ii(0x100e_3071, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_3074, 4); test(memb_a32[ds, eax + 0x15], 0x10);   /* test byte [eax+0x15], 0x10 */
            ii(0x100e_3078, 2); if(jzd(0x100e_3080, 0x6)) goto l_0x100e_3080; /* jz 0x100e3080 */
        l_0x100e_307a:
            ii(0x100e_307a, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_307e, 2); jmpd(0x100e_30db, 0x5b); goto l_0x100e_30db; /* jmp 0x100e30db */
        l_0x100e_3080:
            ii(0x100e_3080, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_3083, 5); calld(0x1007_20b1, -0x7_0fd7);          /* call 0x100720b1 */
            ii(0x100e_3088, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100e_308b, 5); calld(0x1007_20b1, -0x7_0fdf);          /* call 0x100720b1 */
            ii(0x100e_3090, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x100e_3093, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100e_3096, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_3099, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_309c, 5); calld(0x1007_6574, -0x6_cb2d);          /* call 0x10076574 */
            ii(0x100e_30a1, 5); calld(0x1007_6204, -0x6_cea2);          /* call 0x10076204 */
            ii(0x100e_30a6, 5); calld(0x1014_3616, 0x6_056b);           /* call 0x10143616 */
            ii(0x100e_30ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_30ae, 5); calld(0x1015_09a6, 0x6_d8f3);           /* call 0x101509a6 */
            ii(0x100e_30b3, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_30b6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_30b8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_30bb, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100e_30be, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100e_30c0, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x100e_30c3, 4); movsx(edx, memw_a32[ss, ebp - 0x1a]);   /* movsx edx, word [ebp-0x1a] */
            ii(0x100e_30c7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_30c9, 2); if(jld(0x100e_30d1, 0x6)) goto l_0x100e_30d1; /* jl 0x100e30d1 */
            ii(0x100e_30cb, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100e_30cf, 2); jmpd(0x100e_30d5, 0x4); goto l_0x100e_30d5; /* jmp 0x100e30d5 */
        l_0x100e_30d1:
            ii(0x100e_30d1, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x100e_30d5:
            ii(0x100e_30d5, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100e_30d8, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x100e_30db:
            ii(0x100e_30db, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100e_30de, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_30e0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_30e1, 1); popd(edi);                              /* pop edi */
            ii(0x100e_30e2, 1); popd(esi);                              /* pop esi */
            ii(0x100e_30e3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_30e4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_30e5, 1); retd(); return;                         /* ret */
        }
    }
}
