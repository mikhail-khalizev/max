using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_338c-d5edf30a")]
        public void Method_1013_338c()
        {
            ii(0x1013_338c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1013_3390, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1013_3393, 6); if(jged_func(0x1013_3677, 0x2de)) return; /* jge 0x10133677 */
            ii(0x1013_3399, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_339c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_339f, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_33a3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_33a6, 5); calld(0x100c_b6b0, -0x6_7cfb);          /* call 0x100cb6b0 */
            ii(0x1013_33ab, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1013_33ae, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_33b0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_33b2, 5); calld(0x1007_6800, -0xb_cbb7);          /* call 0x10076800 */
            ii(0x1013_33b7, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1013_33bc, 5); calld(Definitions.sys_new, 0x3_2a3f);   /* call 0x10165e00 */
            ii(0x1013_33c1, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_33c4, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1013_33c7, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1013_33ca, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1013_33ce, 2); if(jzd(0x1013_33f3, 0x23)) goto l_0x1013_33f3; /* jz 0x101333f3 */
            ii(0x1013_33d0, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_33d4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_33d7, 5); calld(0x1008_b104, -0xa_82d8);          /* call 0x1008b104 */
            ii(0x1013_33dc, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x1013_33df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_33e1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_33e3, 5); calld(0x100c_a2f8, -0x6_90f0);          /* call 0x100ca2f8 */
            ii(0x1013_33e8, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1013_33eb, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1013_33ee, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1013_33f1, 2); jmpd(0x1013_33f9, 0x6); goto l_0x1013_33f9; /* jmp 0x101333f9 */
        l_0x1013_33f3:
            ii(0x1013_33f3, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1013_33f6, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x1013_33f9:
            ii(0x1013_33f9, 3); mov(edx, memd_a32[ss, ebp - 0x30]);     /* mov edx, [ebp-0x30] */
            ii(0x1013_33fc, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_33ff, 5); calld(0x1007_6800, -0xb_cc04);          /* call 0x10076800 */
            ii(0x1013_3404, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_3407, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1013_340a, 5); if(jmpd_func(0x1013_353c, 0x12d)) return; /* jmp 0x1013353c */
            ii(0x1013_340f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_3412, 5); calld(0x1007_6730, -0xb_cce7);          /* call 0x10076730 */
            ii(0x1013_3417, 4); mov(ax, memw_a32[ds, eax + 0xe]);       /* mov ax, [eax+0xe] */
            ii(0x1013_341b, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1013_341e, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3421, 5); calld(0x1007_6730, -0xb_ccf6);          /* call 0x10076730 */
            ii(0x1013_3426, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_3429, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1013_342c, 5); if(jmpd_func(0x1013_3557, 0x126)) return; /* jmp 0x10133557 */
            ii(0x1013_3431, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_3434, 5); calld(0x1007_6730, -0xb_cd09);          /* call 0x10076730 */
            ii(0x1013_3439, 4); mov(ax, memw_a32[ds, eax + 0x14]);      /* mov ax, [eax+0x14] */
            ii(0x1013_343d, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1013_3440, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3443, 5); calld(0x1007_6730, -0xb_cd18);          /* call 0x10076730 */
            ii(0x1013_3448, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1013_344b, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1013_344e, 5); if(jmpd_func(0x1013_3557, 0x104)) return; /* jmp 0x10133557 */
            ii(0x1013_3453, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_3456, 5); calld(0x1007_6730, -0xb_cd2b);          /* call 0x10076730 */
            ii(0x1013_345b, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x1013_345f, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1013_3462, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3465, 5); calld(0x1007_6730, -0xb_cd3a);          /* call 0x10076730 */
            ii(0x1013_346a, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1013_346d, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1013_3470, 5); if(jmpd_func(0x1013_3557, 0xe2)) return; /* jmp 0x10133557 */
            ii(0x1013_3475, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_3478, 5); calld(0x1007_6730, -0xb_cd4d);          /* call 0x10076730 */
            ii(0x1013_347d, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1013_3481, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1013_3484, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3487, 5); calld(0x1007_6730, -0xb_cd5c);          /* call 0x10076730 */
            ii(0x1013_348c, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1013_348f, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1013_3492, 5); if(jmpd_func(0x1013_3557, 0xc0)) return; /* jmp 0x10133557 */
            ii(0x1013_3497, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_349a, 5); calld(0x1007_6730, -0xb_cd6f);          /* call 0x10076730 */
            ii(0x1013_349f, 4); mov(ax, memw_a32[ds, eax + 0xa]);       /* mov ax, [eax+0xa] */
            ii(0x1013_34a3, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1013_34a6, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_34a9, 5); calld(0x1007_6730, -0xb_cd7e);          /* call 0x10076730 */
            ii(0x1013_34ae, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_34b1, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1013_34b4, 5); if(jmpd_func(0x1013_3557, 0x9e)) return; /* jmp 0x10133557 */
            ii(0x1013_34b9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_34bc, 5); calld(0x1007_6730, -0xb_cd91);          /* call 0x10076730 */
            ii(0x1013_34c1, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x1013_34c5, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1013_34c8, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_34cb, 5); calld(0x1007_6730, -0xb_cda0);          /* call 0x10076730 */
            ii(0x1013_34d0, 3); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1013_34d3, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1013_34d6, 5); if(jmpd_func(0x1013_3557, 0x7c)) return; /* jmp 0x10133557 */
            ii(0x1013_34db, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_34de, 5); calld(0x1007_6730, -0xb_cdb3);          /* call 0x10076730 */
            ii(0x1013_34e3, 4); mov(ax, memw_a32[ds, eax + 0x17]);      /* mov ax, [eax+0x17] */
            ii(0x1013_34e7, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1013_34ea, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_34ed, 5); calld(0x1007_6730, -0xb_cdc2);          /* call 0x10076730 */
            ii(0x1013_34f2, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1013_34f5, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1013_34f8, 2); if(jmpd_func(0x1013_3557, 0x5d)) return; /* jmp 0x10133557 */
            ii(0x1013_34fa, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_34fd, 5); calld(0x1007_6730, -0xb_cdd2);          /* call 0x10076730 */
            ii(0x1013_3502, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1013_3506, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1013_3509, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_350c, 5); calld(0x1007_6730, -0xb_cde1);          /* call 0x10076730 */
            ii(0x1013_3511, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1013_3514, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        }
    }
}
