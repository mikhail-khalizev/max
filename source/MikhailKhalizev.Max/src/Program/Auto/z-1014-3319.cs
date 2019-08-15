using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fa56b2ca-3908-4379-8f10-41bb0122a6e6")]
        public void Method_1014_3319()
        {
            ii(0x1014_3319, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x1014_331e, 5); calld(Definitions.sys_check_available_stack_size, 0x2_2a2f); /* call 0x10165d52 */
            ii(0x1014_3323, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_3324, 1); pushd(esi);                             /* push esi */
            ii(0x1014_3325, 1); pushd(edi);                             /* push edi */
            ii(0x1014_3326, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_3327, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_3329, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1014_332f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_3332, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_3335, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_3338, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1014_333c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_333f, 5); calld(0x1007_64fc, -0xc_ce48);          /* call 0x100764fc */
            ii(0x1014_3344, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_3347, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1014_334b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_334e, 5); calld(0x1007_20e6, -0xd_126d);          /* call 0x100720e6 */
            ii(0x1014_3353, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_3356, 5); calld(0x1007_20e6, -0xd_1275);          /* call 0x100720e6 */
            ii(0x1014_335b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1014_3360, 5); calld(0x1007_6338, -0xc_d02d);          /* call 0x10076338 */
            ii(0x1014_3365, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_3367, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_336a, 5); calld(0x1007_643c, -0xc_cf33);          /* call 0x1007643c */
        l_0x1014_336f:
            ii(0x1014_336f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3371, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3374, 5); calld(0x1013_ad71, -0x8608);            /* call 0x1013ad71 */
            ii(0x1014_3379, 2); test(al, al);                           /* test al, al */
            ii(0x1014_337b, 6); if(jzd(0x1014_34c3, 0x142)) goto l_0x1014_34c3; /* jz 0x101434c3 */
            ii(0x1014_3381, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3384, 5); calld(0x1007_63a0, -0xc_cfe9);          /* call 0x100763a0 */
            ii(0x1014_3389, 5); calld(0x1007_6204, -0xc_d18a);          /* call 0x10076204 */
            ii(0x1014_338e, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1014_3391, 2); if(jnzd(0x1014_33a2, 0xf)) goto l_0x1014_33a2; /* jnz 0x101433a2 */
            ii(0x1014_3393, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3396, 5); calld(0x1007_63a0, -0xc_cffb);          /* call 0x100763a0 */
            ii(0x1014_339b, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x1014_33a0, 2); if(jzd(0x1014_33a4, 0x2)) goto l_0x1014_33a4; /* jz 0x101433a4 */
        l_0x1014_33a2:
            ii(0x1014_33a2, 2); jmpd(0x1014_33b2, 0xe); goto l_0x1014_33b2; /* jmp 0x101433b2 */
        l_0x1014_33a4:
            ii(0x1014_33a4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_33a7, 5); calld(0x1007_63a0, -0xc_d00c);          /* call 0x100763a0 */
            ii(0x1014_33ac, 4); cmp(memb_a32[ds, eax + 0x3d], 0x8);     /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1014_33b0, 2); if(jnzd(0x1014_33b4, 0x2)) goto l_0x1014_33b4; /* jnz 0x101433b4 */
        l_0x1014_33b2:
            ii(0x1014_33b2, 2); jmpd(0x1014_33c2, 0xe); goto l_0x1014_33c2; /* jmp 0x101433c2 */
        l_0x1014_33b4:
            ii(0x1014_33b4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_33b7, 5); calld(0x1007_63a0, -0xc_d01c);          /* call 0x100763a0 */
            ii(0x1014_33bc, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1014_33c0, 2); if(jnzd(0x1014_33c4, 0x2)) goto l_0x1014_33c4; /* jnz 0x101433c4 */
        l_0x1014_33c2:
            ii(0x1014_33c2, 2); jmpd(0x1014_33d2, 0xe); goto l_0x1014_33d2; /* jmp 0x101433d2 */
        l_0x1014_33c4:
            ii(0x1014_33c4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_33c7, 5); calld(0x1007_63a0, -0xc_d02c);          /* call 0x100763a0 */
            ii(0x1014_33cc, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1014_33d0, 2); if(jnzd(0x1014_33d7, 0x5)) goto l_0x1014_33d7; /* jnz 0x101433d7 */
        l_0x1014_33d2:
            ii(0x1014_33d2, 5); jmpd(0x1014_34b6, 0xdf); goto l_0x1014_34b6; /* jmp 0x101434b6 */
        l_0x1014_33d7:
            ii(0x1014_33d7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_33da, 5); calld(0x1007_63a0, -0xc_d03f);          /* call 0x100763a0 */
            ii(0x1014_33df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_33e1, 3); mov(dl, memb_a32[ds, eax + 0x49]);      /* mov dl, [eax+0x49] */
            ii(0x1014_33e4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_33e7, 3); add(memw_a32[ds, eax], dx);             /* add [eax], dx */
            ii(0x1014_33ea, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_33ed, 5); calld(0x1007_63a0, -0xc_d052);          /* call 0x100763a0 */
            ii(0x1014_33f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_33f4, 3); mov(dl, memb_a32[ds, eax + 0x47]);      /* mov dl, [eax+0x47] */
            ii(0x1014_33f7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_33fa, 4); add(memw_a32[ds, eax + 0x2], dx);       /* add [eax+0x2], dx */
            ii(0x1014_33fe, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3401, 5); calld(0x1007_63a0, -0xc_d066);          /* call 0x100763a0 */
            ii(0x1014_3406, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3408, 3); mov(dl, memb_a32[ds, eax + 0x48]);      /* mov dl, [eax+0x48] */
            ii(0x1014_340b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_340e, 4); add(memw_a32[ds, eax + 0x4], dx);       /* add [eax+0x4], dx */
            ii(0x1014_3412, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3415, 5); calld(0x1007_63a0, -0xc_d07a);          /* call 0x100763a0 */
            ii(0x1014_341a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_341c, 3); mov(bl, memb_a32[ds, eax + 0x49]);      /* mov bl, [eax+0x49] */
            ii(0x1014_341f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3422, 5); calld(0x1007_63a0, -0xc_d087);          /* call 0x100763a0 */
            ii(0x1014_3427, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3429, 3); mov(dl, memb_a32[ds, eax + 0x47]);      /* mov dl, [eax+0x47] */
            ii(0x1014_342c, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1014_342e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3431, 5); calld(0x1007_63a0, -0xc_d096);          /* call 0x100763a0 */
            ii(0x1014_3436, 3); mov(al, memb_a32[ds, eax + 0x48]);      /* mov al, [eax+0x48] */
            ii(0x1014_3439, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_343b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_343d, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1014_3442, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_3444, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_3446, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_3449, 4); add(memw_a32[ds, edx + 0xa], ax);       /* add [edx+0xa], ax */
            ii(0x1014_344d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3450, 5); calld(0x1007_63a0, -0xc_d0b5);          /* call 0x100763a0 */
            ii(0x1014_3455, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_3458, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_345a, 1); cwde();                                 /* cwde */
            ii(0x1014_345b, 1); pushd(eax);                             /* push eax */
            ii(0x1014_345c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_3461, 1); pushd(eax);                             /* push eax */
            ii(0x1014_3462, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_3465, 1); pushd(eax);                             /* push eax */
            ii(0x1014_3466, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_3469, 1); pushd(eax);                             /* push eax */
            ii(0x1014_346a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_346d, 1); pushd(eax);                             /* push eax */
            ii(0x1014_346e, 5); mov(ecx, 0x10);                         /* mov ecx, 0x10 */
            ii(0x1014_3473, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_3478, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_347b, 5); calld(0x1007_63a0, -0xc_d0e0);          /* call 0x100763a0 */
            ii(0x1014_3480, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1014_3483, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_3486, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3489, 5); calld(0x1007_63a0, -0xc_d0ee);          /* call 0x100763a0 */
            ii(0x1014_348e, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1014_3491, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_3494, 5); calld(0x1014_2b18, -0x981);             /* call 0x10142b18 */
            ii(0x1014_3499, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_349c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_349f, 4); add(memw_a32[ds, edx + 0x2], ax);       /* add [edx+0x2], ax */
            ii(0x1014_34a3, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_34a6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_34a9, 3); add(memw_a32[ds, edx], ax);             /* add [edx], ax */
            ii(0x1014_34ac, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_34af, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_34b2, 4); add(memw_a32[ds, edx + 0x4], ax);       /* add [edx+0x4], ax */
        l_0x1014_34b6:
            ii(0x1014_34b6, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_34b9, 5); calld(0x1007_6bf8, -0xc_c8c6);          /* call 0x10076bf8 */
            ii(0x1014_34be, 5); jmpd(0x1014_336f, -0x154); goto l_0x1014_336f; /* jmp 0x1014336f */
        l_0x1014_34c3:
            ii(0x1014_34c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_34c5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_34c8, 5); calld(0x1007_5f6c, -0xc_d561);          /* call 0x10075f6c */
            ii(0x1014_34cd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_34cf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_34d0, 1); popd(edi);                              /* pop edi */
            ii(0x1014_34d1, 1); popd(esi);                              /* pop esi */
            ii(0x1014_34d2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_34d3, 1); retd(); return;                         /* ret */
        }
    }
}
