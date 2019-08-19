using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_a3f7-aef92bfb")]
        public void Method_1011_a3f7()
        {
            ii(0x1011_a3f7, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1011_a3fc, 5); calld(Definitions.sys_check_available_stack_size, 0x4_b951); /* call 0x10165d52 */
            ii(0x1011_a401, 1); pushd(esi);                             /* push esi */
            ii(0x1011_a402, 1); pushd(edi);                             /* push edi */
            ii(0x1011_a403, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_a404, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_a406, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1011_a40c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_a40f, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_a412, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_a415, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1011_a418, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1011_a41c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a41f, 5); calld(0x1007_64fc, -0xa_3f28);          /* call 0x100764fc */
            ii(0x1011_a424, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_a427, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1011_a42b, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1011_a42f, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1011_a433, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1011_a438, 5); calld(0x1010_3541, -0x1_6efc);          /* call 0x10103541 */
            ii(0x1011_a43d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_a43f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a442, 5); calld(0x1007_643c, -0xa_400b);          /* call 0x1007643c */
            ii(0x1011_a447, 2); jmpd(0x1011_a451, 0x8); goto l_0x1011_a451; /* jmp 0x1011a451 */
        l_0x1011_a449:
            ii(0x1011_a449, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a44c, 5); calld(0x1007_6bf8, -0xa_3859);          /* call 0x10076bf8 */
        l_0x1011_a451:
            ii(0x1011_a451, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a453, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a456, 5); calld(0x1013_ad71, 0x2_0916);           /* call 0x1013ad71 */
            ii(0x1011_a45b, 2); test(al, al);                           /* test al, al */
            ii(0x1011_a45d, 6); if(jzd(0x1011_a4ec, 0x89)) goto l_0x1011_a4ec; /* jz 0x1011a4ec */
            ii(0x1011_a463, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a466, 5); calld(0x1007_63a0, -0xa_40cb);          /* call 0x100763a0 */
            ii(0x1011_a46b, 5); cmp(memw_a32[ds, eax + 0x8], 0x47);     /* cmp word [eax+0x8], 0x47 */
            ii(0x1011_a470, 2); if(jzd(0x1011_a481, 0xf)) goto l_0x1011_a481; /* jz 0x1011a481 */
            ii(0x1011_a472, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a475, 5); calld(0x1007_63a0, -0xa_40da);          /* call 0x100763a0 */
            ii(0x1011_a47a, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1011_a47f, 2); if(jnzd(0x1011_a483, 0x2)) goto l_0x1011_a483; /* jnz 0x1011a483 */
        l_0x1011_a481:
            ii(0x1011_a481, 2); jmpd(0x1011_a492, 0xf); goto l_0x1011_a492; /* jmp 0x1011a492 */
        l_0x1011_a483:
            ii(0x1011_a483, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a486, 5); calld(0x1007_63a0, -0xa_40eb);          /* call 0x100763a0 */
            ii(0x1011_a48b, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x1011_a490, 2); if(jnzd(0x1011_a4e7, 0x55)) goto l_0x1011_a4e7; /* jnz 0x1011a4e7 */
        l_0x1011_a492:
            ii(0x1011_a492, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1011_a496, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a499, 5); calld(0x1007_63a0, -0xa_40fe);          /* call 0x100763a0 */
            ii(0x1011_a49e, 5); calld(0x1007_6074, -0xa_442f);          /* call 0x10076074 */
            ii(0x1011_a4a3, 2); test(al, al);                           /* test al, al */
            ii(0x1011_a4a5, 2); if(jnzd(0x1011_a4c4, 0x1d)) goto l_0x1011_a4c4; /* jnz 0x1011a4c4 */
            ii(0x1011_a4a7, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x1011_a4ab, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1011_a4af, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1011_a4b3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a4b6, 5); calld(0x1007_63a0, -0xa_411b);          /* call 0x100763a0 */
            ii(0x1011_a4bb, 5); calld(0x1015_4b8b, 0x3_a6cb);           /* call 0x10154b8b */
            ii(0x1011_a4c0, 2); test(al, al);                           /* test al, al */
            ii(0x1011_a4c2, 2); if(jzd(0x1011_a4c6, 0x2)) goto l_0x1011_a4c6; /* jz 0x1011a4c6 */
        l_0x1011_a4c4:
            ii(0x1011_a4c4, 2); jmpd(0x1011_a4e7, 0x21); goto l_0x1011_a4e7; /* jmp 0x1011a4e7 */
        l_0x1011_a4c6:
            ii(0x1011_a4c6, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1011_a4ca, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a4cd, 5); calld(0x1007_63a0, -0xa_4132);          /* call 0x100763a0 */
            ii(0x1011_a4d2, 5); calld(0x1014_f634, 0x3_515d);           /* call 0x1014f634 */
            ii(0x1011_a4d7, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1011_a4db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a4dd, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a4e0, 5); calld(0x1007_5f6c, -0xa_4579);          /* call 0x10075f6c */
            ii(0x1011_a4e5, 2); jmpd(0x1011_a506, 0x1f); goto l_0x1011_a506; /* jmp 0x1011a506 */
        l_0x1011_a4e7:
            ii(0x1011_a4e7, 5); jmpd(0x1011_a449, -0xa3); goto l_0x1011_a449; /* jmp 0x1011a449 */
        l_0x1011_a4ec:
            ii(0x1011_a4ec, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
            ii(0x1011_a4f0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a4f2, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_a4f5, 5); calld(0x1007_5f6c, -0xa_458e);          /* call 0x10075f6c */
            ii(0x1011_a4fa, 2); jmpd(0x1011_a506, 0xa); goto l_0x1011_a506; /* jmp 0x1011a506 */
        //  ii(0x1011_a4fc, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1011_a4fe, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
        //  ii(0x1011_a501, 5); calld(0x1007_5f6c, -0xa_459a);          /* call 0x10075f6c */
        l_0x1011_a506:
            ii(0x1011_a506, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1011_a509, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_a50b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_a50c, 1); popd(edi);                              /* pop edi */
            ii(0x1011_a50d, 1); popd(esi);                              /* pop esi */
            ii(0x1011_a50e, 1); retd(); return;                         /* ret */
        }
    }
}
