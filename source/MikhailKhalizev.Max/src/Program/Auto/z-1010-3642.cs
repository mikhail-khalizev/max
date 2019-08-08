using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("60493681-0603-4733-9b14-5c378e644d96")]
        public void Method_1010_3642()
        {
            ii(0x1010_3642, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1010_3647, 5); calld(Definitions.sys_check_available_stack_size, 0x6_2706); /* call 0x10165d52 */
            ii(0x1010_364c, 1); pushd(esi);                             /* push esi */
            ii(0x1010_364d, 1); pushd(edi);                             /* push edi */
            ii(0x1010_364e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_364f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3651, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1010_3657, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_365a, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_365d, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1010_3660, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1010_3663, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_3666, 2); mov(ecx, memd_a32[ds, edx]);            /* mov ecx, [edx] */
            ii(0x1010_3668, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1010_366b, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_366f, 2); shl(edx, cl);                           /* shl edx, cl */
            ii(0x1010_3671, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_3675, 2); xor(edx, eax);                          /* xor edx, eax */
            ii(0x1010_3677, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_367a, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1010_367d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_367f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_3682, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x1010_3684, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1010_3687, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_368b, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1010_368e, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_3691, 3); mov(edx, memd_a32[ds, edx + 0x4]);      /* mov edx, [edx+0x4] */
            ii(0x1010_3694, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_3696, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1010_3699, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_369c, 5); calld(0x1010_46a4, 0x1003);             /* call 0x101046a4 */
            ii(0x1010_36a1, 3); lea(ecx, ebp - 0x1c);                   /* lea ecx, [ebp-0x1c] */
            ii(0x1010_36a4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_36a6, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1010_36a8, 5); calld(0x1010_4590, 0xee3);              /* call 0x10104590 */
        l_0x1010_36ad:
            ii(0x1010_36ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_36af, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_36b2, 5); calld(0x1013_ad71, 0x3_76ba);           /* call 0x1013ad71 */
            ii(0x1010_36b7, 2); test(al, al);                           /* test al, al */
            ii(0x1010_36b9, 2); if(jzd(0x1010_36e3, 0x28)) goto l_0x1010_36e3; /* jz 0x101036e3 */
            ii(0x1010_36bb, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_36be, 5); calld(0x1010_44b0, 0xded);              /* call 0x101044b0 */
            ii(0x1010_36c3, 5); calld(0x1010_4790, 0x10c8);             /* call 0x10104790 */
            ii(0x1010_36c8, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1010_36cc, 2); if(jnzd(0x1010_36e1, 0x13)) goto l_0x1010_36e1; /* jnz 0x101036e1 */
            ii(0x1010_36ce, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_36d1, 5); calld(0x1010_44b0, 0xdda);              /* call 0x101044b0 */
            ii(0x1010_36d6, 5); calld(0x1010_475c, 0x1081);             /* call 0x1010475c */
            ii(0x1010_36db, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1010_36df, 2); if(jzd(0x1010_36e3, 0x2)) goto l_0x1010_36e3; /* jz 0x101036e3 */
        l_0x1010_36e1:
            ii(0x1010_36e1, 2); jmpd(0x1010_36e5, 0x2); goto l_0x1010_36e5; /* jmp 0x101036e5 */
        l_0x1010_36e3:
            ii(0x1010_36e3, 2); jmpd(0x1010_36ef, 0xa); goto l_0x1010_36ef; /* jmp 0x101036ef */
        l_0x1010_36e5:
            ii(0x1010_36e5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_36e8, 5); calld(0x1007_6bf8, -0x8_caf5);          /* call 0x10076bf8 */
            ii(0x1010_36ed, 2); jmpd(0x1010_36ad, -0x42); goto l_0x1010_36ad; /* jmp 0x101036ad */
        l_0x1010_36ef:
            ii(0x1010_36ef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_36f1, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_36f4, 5); calld(0x1013_ad11, 0x3_7618);           /* call 0x1013ad11 */
            ii(0x1010_36f9, 2); test(al, al);                           /* test al, al */
            ii(0x1010_36fb, 2); if(jzd(0x1010_3709, 0xc)) goto l_0x1010_3709; /* jz 0x10103709 */
            ii(0x1010_36fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_36ff, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_3702, 5); calld(0x1010_4470, 0xd69);              /* call 0x10104470 */
            ii(0x1010_3707, 2); jmpd(0x1010_374c, 0x43); goto l_0x1010_374c; /* jmp 0x1010374c */
        l_0x1010_3709:
            ii(0x1010_3709, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_370c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_370f, 5); calld(0x1010_44b0, 0xd9c);              /* call 0x101044b0 */
            ii(0x1010_3714, 5); calld(0x1010_47f4, 0x10db);             /* call 0x101047f4 */
            ii(0x1010_3719, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_371c, 5); calld(0x1010_44b0, 0xd8f);              /* call 0x101044b0 */
            ii(0x1010_3721, 5); calld(0x1010_47c4, 0x109e);             /* call 0x101047c4 */
            ii(0x1010_3726, 5); calld(0x1007_6b90, -0x8_cb9b);          /* call 0x10076b90 */
            ii(0x1010_372b, 1); cwde();                                 /* cwde */
            ii(0x1010_372c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_372e, 2); if(jnzd(0x1010_3742, 0x12)) goto l_0x1010_3742; /* jnz 0x10103742 */
            ii(0x1010_3730, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_3733, 5); calld(0x1010_44e4, 0xdac);              /* call 0x101044e4 */
            ii(0x1010_3738, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_373a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_373d, 5); calld(0x1010_4614, 0xed2);              /* call 0x10104614 */
        l_0x1010_3742:
            ii(0x1010_3742, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3744, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_3747, 5); calld(0x1010_4470, 0xd24);              /* call 0x10104470 */
        l_0x1010_374c:
            ii(0x1010_374c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_374e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_374f, 1); popd(edi);                              /* pop edi */
            ii(0x1010_3750, 1); popd(esi);                              /* pop esi */
            ii(0x1010_3751, 1); retd(); return;                         /* ret */
        }
    }
}
