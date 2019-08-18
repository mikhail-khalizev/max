using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_28f6-8598560f")]
        public void Method_1011_28f6()
        {
            ii(0x1011_28f6, 5); pushd(0x70);                            /* push 0x70 */
            ii(0x1011_28fb, 5); calld(Definitions.sys_check_available_stack_size, 0x5_3452); /* call 0x10165d52 */
            ii(0x1011_2900, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_2901, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_2902, 1); pushd(esi);                             /* push esi */
            ii(0x1011_2903, 1); pushd(edi);                             /* push edi */
            ii(0x1011_2904, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_2905, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_2907, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1011_290d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_2910, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_2913, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2917, 3); imul(edx, eax, 0x18);                   /* imul edx, eax, 0x18 */
            ii(0x1011_291a, 5); mov(eax, 0x101b_9ea4);                  /* mov eax, 0x101b9ea4 */
            ii(0x1011_291f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_2921, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_2924, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2927, 7); mov(memb_a32[ds, eax + 0x1a2], 0);      /* mov byte [eax+0x1a2], 0x0 */
            ii(0x1011_292e, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x1011_2933, 5); calld(Definitions.sys_new, 0x5_34c8);   /* call 0x10165e00 */
            ii(0x1011_2938, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_293b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_293e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_2941, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_2945, 6); if(jzd(0x1011_29e1, 0x96)) goto l_0x1011_29e1; /* jz 0x101129e1 */
            ii(0x1011_294b, 7); mov(memd_a32[ss, ebp - 0x18], 0x5);     /* mov dword [ebp-0x18], 0x5 */
            ii(0x1011_2952, 3); pushd(memd_a32[ss, ebp - 0x18]);        /* push dword [ebp-0x18] */
            ii(0x1011_2955, 7); mov(memd_a32[ss, ebp - 0x1c], 0xa2);    /* mov dword [ebp-0x1c], 0xa2 */
            ii(0x1011_295c, 3); pushd(memd_a32[ss, ebp - 0x1c]);        /* push dword [ebp-0x1c] */
            ii(0x1011_295f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_2962, 4); mov(ax, memw_a32[ds, eax + 0x6]);       /* mov ax, [eax+0x6] */
            ii(0x1011_2966, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_2969, 4); sub(ax, memw_a32[ds, edx + 0x2]);       /* sub ax, [edx+0x2] */
            ii(0x1011_296d, 1); inc(eax);                               /* inc eax */
            ii(0x1011_296e, 1); cwde();                                 /* cwde */
            ii(0x1011_296f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_2972, 3); pushd(memd_a32[ss, ebp - 0x20]);        /* push dword [ebp-0x20] */
            ii(0x1011_2975, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_2978, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1011_297c, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_297f, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1011_2982, 1); inc(eax);                               /* inc eax */
            ii(0x1011_2983, 1); cwde();                                 /* cwde */
            ii(0x1011_2984, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1011_2987, 3); pushd(memd_a32[ss, ebp - 0x24]);        /* push dword [ebp-0x24] */
            ii(0x1011_298a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_298d, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_298f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_2992, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_2995, 3); pushd(memd_a32[ss, ebp - 0x28]);        /* push dword [ebp-0x28] */
            ii(0x1011_2998, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_299b, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1011_299e, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1011_29a1, 3); pushd(memd_a32[ss, ebp - 0x2c]);        /* push dword [ebp-0x2c] */
            ii(0x1011_29a4, 4); cmp(memb_a32[ss, ebp - 0x4], 0x12);     /* cmp byte [ebp-0x4], 0x12 */
            ii(0x1011_29a8, 2); if(jnzd(0x1011_29b3, 0x9)) goto l_0x1011_29b3; /* jnz 0x101129b3 */
            ii(0x1011_29aa, 7); mov(memd_a32[ss, ebp - 0x30], 0x78);    /* mov dword [ebp-0x30], 0x78 */
            ii(0x1011_29b1, 2); jmpd(0x1011_29ba, 0x7); goto l_0x1011_29ba; /* jmp 0x101129ba */
        l_0x1011_29b3:
            ii(0x1011_29b3, 7); mov(memd_a32[ss, ebp - 0x30], 0x1e);    /* mov dword [ebp-0x30], 0x1e */
        l_0x1011_29ba:
            ii(0x1011_29ba, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1011_29bd, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1011_29c0, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_29c3, 6); add(ebx, 0x1a2);                        /* add ebx, 0x1a2 */
            ii(0x1011_29c9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_29cc, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_29ce, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_29d1, 5); calld(0x100e_af58, -0x2_7a7e);          /* call 0x100eaf58 */
            ii(0x1011_29d6, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1011_29d9, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1011_29dc, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1011_29df, 2); jmpd(0x1011_29e7, 0x6); goto l_0x1011_29e7; /* jmp 0x101129e7 */
        l_0x1011_29e1:
            ii(0x1011_29e1, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_29e4, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1011_29e7:
            ii(0x1011_29e7, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1011_29ea, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1011_29ed, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1011_29f0, 5); calld(0x100e_b180, -0x2_7875);          /* call 0x100eb180 */
            ii(0x1011_29f5, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1011_29f8, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1011_29fb, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1011_29fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_2a00, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_2a01, 1); popd(edi);                              /* pop edi */
            ii(0x1011_2a02, 1); popd(esi);                              /* pop esi */
            ii(0x1011_2a03, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_2a04, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_2a05, 1); retd(); return;                         /* ret */
        }
    }
}
