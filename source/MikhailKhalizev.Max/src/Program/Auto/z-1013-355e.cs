using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("138d8668-7df9-4efa-9137-efaddd4cf0e2")]
        public void Method_1013_355e()
        {
            ii(0x1013_355e, 5); mov(edi, 0xc283_f455);                  /* mov edi, 0xc283f455 */
            ii(0x1013_3563, 6); or(cl, memb_a32[ds, ecx + 0x1ffa_c1d0]); /* or cl, [ecx+0x1ffac1d0] */
            ii(0x1013_3569, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_356b, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_356d, 4); movsx(edx, memw_a32[ss, ebp - 0x38]);   /* movsx edx, word [ebp-0x38] */
            ii(0x1013_3571, 3); imul(edx, edx, 0xa);                    /* imul edx, edx, 0xa */
            ii(0x1013_3574, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_3576, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_357a, 3); lea(ebx, eax + 0xa);                    /* lea ebx, [eax+0xa] */
            ii(0x1013_357d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_357f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3582, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_3584, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1013_3587, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_358b, 3); add(edx, 0x9);                          /* add edx, 0x9 */
            ii(0x1013_358e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_3590, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3593, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_3595, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_3597, 4); movsx(edx, memw_a32[ss, ebp - 0x38]);   /* movsx edx, word [ebp-0x38] */
            ii(0x1013_359b, 3); imul(edx, edx, 0xa);                    /* imul edx, edx, 0xa */
            ii(0x1013_359e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_35a0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_35a4, 3); lea(ebx, eax + 0x9);                    /* lea ebx, [eax+0x9] */
            ii(0x1013_35a7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_35a9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_35ac, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_35ae, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1013_35b1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_35b6, 4); movsx(eax, memw_a32[ss, ebp - 0x44]);   /* movsx eax, word [ebp-0x44] */
            ii(0x1013_35ba, 5); calld(0x1007_6e7c, -0xb_c743);          /* call 0x10076e7c */
            ii(0x1013_35bf, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1013_35c2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_35c7, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x1013_35cb, 5); calld(0x1007_6e7c, -0xb_c754);          /* call 0x10076e7c */
            ii(0x1013_35d0, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1013_35d3, 2); jmpd(0x1013_360a, 0x35); goto l_0x1013_360a; /* jmp 0x1013360a */
        //    ii(0x1013_35d5, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
        //    ii(0x1013_35d9, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
        //    ii(0x1013_35dd, 1); dec(edx);                               /* dec edx */
        //    ii(0x1013_35de, 3); imul(edx, eax);                         /* imul edx, eax */
        //    ii(0x1013_35e1, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
        //    ii(0x1013_35e6, 2); mov(eax, edx);                          /* mov eax, edx */
        //    ii(0x1013_35e8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
        //    ii(0x1013_35eb, 2); idiv(ebx);                              /* idiv ebx */
        //    ii(0x1013_35ed, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        //    ii(0x1013_35f0, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
        //    ii(0x1013_35f4, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
        //    ii(0x1013_35f8, 3); imul(edx, eax);                         /* imul edx, eax */
        //    ii(0x1013_35fb, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
        //    ii(0x1013_3600, 2); mov(eax, edx);                          /* mov eax, edx */
        //    ii(0x1013_3602, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
        //    ii(0x1013_3605, 2); idiv(ebx);                              /* idiv ebx */
        //    ii(0x1013_3607, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x1013_360a:
            ii(0x1013_360a, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1013_360d, 4); cmp(ax, memw_a32[ss, ebp - 0x48]);      /* cmp ax, [ebp-0x48] */
            ii(0x1013_3611, 2); if(jzd(0x1013_365e, 0x4b)) goto l_0x1013_365e; /* jz 0x1013365e */
            ii(0x1013_3613, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x1013_3616, 3); sub(edx, memd_a32[ss, ebp - 0x48]);     /* sub edx, [ebp-0x48] */
            ii(0x1013_3619, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_361c, 3); add(memw_a32[ds, eax], dx);             /* add [eax], dx */
            ii(0x1013_361f, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3622, 5); calld(0x1007_6730, -0xb_cef7);          /* call 0x10076730 */
            ii(0x1013_3627, 5); calld(0x100c_b7e4, -0x6_7e48);          /* call 0x100cb7e4 */
            ii(0x1013_362c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_362e, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3631, 5); calld(0x1007_6730, -0xb_cf06);          /* call 0x10076730 */
            ii(0x1013_3636, 5); calld(0x100c_b7b4, -0x6_7e87);          /* call 0x100cb7b4 */
            ii(0x1013_363b, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_363e, 5); calld(0x100c_b74c, -0x6_7ef7);          /* call 0x100cb74c */
            ii(0x1013_3643, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_3645, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_3649, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_364d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_3653, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1013_3659, 5); calld(0x100c_b63c, -0x6_8022);          /* call 0x100cb63c */
        l_0x1013_365e:
            ii(0x1013_365e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_3660, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3663, 5); calld(0x1007_5eec, -0xb_d77c);          /* call 0x10075eec */
            ii(0x1013_3668, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_366a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_366d, 5); calld(0x1007_5eec, -0xb_d786);          /* call 0x10075eec */
            ii(0x1013_3672, 5); if(jmpd_func(0x1013_3386, -0x2f1)) return; /* jmp 0x10133386 */
        }
    }
}
