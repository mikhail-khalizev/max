using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("23d5a150-7191-49b1-b6c8-a9f57b56a4fb")]
        public void Method_1013_322d()
        {
            ii(0x1013_322d, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1013_3232, 5); calld(Definitions.sys_check_available_stack_size, 0x3_2b1b); /* call 0x10165d52 */
            ii(0x1013_3237, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_3238, 1); pushd(esi);                             /* push esi */
            ii(0x1013_3239, 1); pushd(edi);                             /* push edi */
            ii(0x1013_323a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_323b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_323d, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1013_3243, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_3246, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1013_3249, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1013_324c, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_3250, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_3256, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1013_325b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_325d, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1013_3261, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1013_3264, 6); add(edx, 0x88);                         /* add edx, 0x88 */
            ii(0x1013_326a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_326c, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1013_326f, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_3272, 2); add(al, 0x1e);                          /* add al, 0x1e */
            ii(0x1013_3274, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1013_3277, 5); calld(0x1007_5fdc, -0xb_d2a0);          /* call 0x10075fdc */
            ii(0x1013_327c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_327f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_3282, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_3284, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_3287, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1013_328e, 3); fild(memq_a32[ss, ebp - 0x1c]);         /* fild qword [ebp-0x1c] */
            ii(0x1013_3291, 6); fdiv(memq_a32[ds, 0x101a_8940]);        /* fdiv qword [0x101a8940] */
            ii(0x1013_3297, 2); fld1();                                 /* fld1 */
            ii(0x1013_3299, 2); faddp(ST(1), ST(0));                    /* faddp st1, st0 */
            ii(0x1013_329b, 3); fstp(memq_a32[ss, ebp - 0x24]);         /* fstp qword [ebp-0x24] */
            ii(0x1013_329e, 3); fld(memq_a32[ss, ebp - 0x24]);          /* fld qword [ebp-0x24] */
            ii(0x1013_32a1, 6); fadd(memq_a32[ds, 0x101a_8948]);        /* fadd qword [0x101a8948] */
            ii(0x1013_32a7, 6); fld(memq_a32[ds, 0x101a_8950]);         /* fld qword [0x101a8950] */
            ii(0x1013_32ad, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1013_32af, 5); calld(/* sys */ 0x1016_c4a0, 0x3_91ec); /* call 0x1016c4a0 */
            ii(0x1013_32b4, 6); fmul(memq_a32[ds, 0x101a_8958]);        /* fmul qword [0x101a8958] */
            ii(0x1013_32ba, 3); fild(memd_a32[ss, ebp - 0x14]);         /* fild dword [ebp-0x14] */
            ii(0x1013_32bd, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1013_32bf, 6); fld(memq_a32[ds, 0x101a_8950]);         /* fld qword [0x101a8950] */
            ii(0x1013_32c5, 3); fld(memq_a32[ss, ebp - 0x24]);          /* fld qword [ebp-0x24] */
            ii(0x1013_32c8, 5); calld(/* sys */ 0x1016_c4a0, 0x3_91d3); /* call 0x1016c4a0 */
            ii(0x1013_32cd, 6); fmul(memq_a32[ds, 0x101a_8958]);        /* fmul qword [0x101a8958] */
            ii(0x1013_32d3, 3); fild(memd_a32[ss, ebp - 0x14]);         /* fild dword [ebp-0x14] */
            ii(0x1013_32d6, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1013_32d8, 2); fsubp(ST(1), ST(0));                    /* fsubp st1, st0 */
            ii(0x1013_32da, 5); calld(Definitions.sys_round, 0x3_2d9f); /* call 0x1016607e */
            ii(0x1013_32df, 3); fistp(memd_a32[ss, ebp - 0x28]);        /* fistp dword [ebp-0x28] */
            ii(0x1013_32e2, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_32e6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_32e9, 3); add(memd_a32[ds, eax + 0x8], edx);      /* add [eax+0x8], edx */
            ii(0x1013_32ec, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_32ef, 4); cmp(memd_a32[ds, eax + 0x8], 0);        /* cmp dword [eax+0x8], 0x0 */
            ii(0x1013_32f3, 2); if(jzd(0x1013_32fe, 0x9)) goto l_0x1013_32fe; /* jz 0x101332fe */
            ii(0x1013_32f5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_32f8, 4); cmp(memd_a32[ds, eax + 0x4], 0);        /* cmp dword [eax+0x4], 0x0 */
            ii(0x1013_32fc, 2); if(jzd(0x1013_3300, 0x2)) goto l_0x1013_3300; /* jz 0x10133300 */
        l_0x1013_32fe:
            ii(0x1013_32fe, 2); jmpd(0x1013_3309, 0x9); goto l_0x1013_3309; /* jmp 0x10133309 */
        l_0x1013_3300:
            ii(0x1013_3300, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1013_3303, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_3306, 3); mov(memd_a32[ds, edx + 0x4], eax);      /* mov [edx+0x4], eax */
        l_0x1013_3309:
            ii(0x1013_3309, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_330c, 4); cmp(memd_a32[ds, eax + 0x8], 0);        /* cmp dword [eax+0x8], 0x0 */
            ii(0x1013_3310, 2); if(jnzd(0x1013_331d, 0xb)) goto l_0x1013_331d; /* jnz 0x1013331d */
            ii(0x1013_3312, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_3315, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1013_3318, 3); cmp(eax, memd_a32[ss, ebp - 0x28]);     /* cmp eax, [ebp-0x28] */
            ii(0x1013_331b, 2); if(jzd(0x1013_331f, 0x2)) goto l_0x1013_331f; /* jz 0x1013331f */
        l_0x1013_331d:
            ii(0x1013_331d, 2); jmpd(0x1013_3329, 0xa); goto l_0x1013_3329; /* jmp 0x10133329 */
        l_0x1013_331f:
            ii(0x1013_331f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_3322, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
        l_0x1013_3329:
            ii(0x1013_3329, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_332b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_332c, 1); popd(edi);                              /* pop edi */
            ii(0x1013_332d, 1); popd(esi);                              /* pop esi */
            ii(0x1013_332e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_332f, 1); retd(); return;                         /* ret */
        }
    }
}
