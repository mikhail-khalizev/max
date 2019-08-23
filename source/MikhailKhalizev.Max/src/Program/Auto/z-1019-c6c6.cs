using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_c6c6-4a6e4b4f")]
        public void Method_1019_c6c6()
        {
            ii(0x1019_c6c6, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c6c7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_c6c8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_c6c9, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c6ca, 1); pushd(esi);                             /* push esi */
            ii(0x1019_c6cb, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1019_c6ce, 4); mov(ecx, memd_a32[ss, esp + 0x28]);     /* mov ecx, [esp+0x28] */
            ii(0x1019_c6d2, 4); fld(memq_a32[ss, esp + 0x20]);          /* fld qword [esp+0x20] */
            ii(0x1019_c6d6, 6); fcomp(memq_a32[ds, 0x101b_7724]);       /* fcomp qword [0x101b7724] */
            ii(0x1019_c6dc, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1019_c6de, 1); sahf();                                 /* sahf */
            ii(0x1019_c6df, 2); if(jnzd(0x1019_c6f1, 0x10)) goto l_0x1019_c6f1; /* jnz 0x1019c6f1 */
            ii(0x1019_c6e1, 5); mov(eax, memd_a32[ds, 0x101b_7734]);    /* mov eax, [0x101b7734] */
            ii(0x1019_c6e6, 4); mov(memd_a32[ss, esp + 0x20], eax);     /* mov [esp+0x20], eax */
            ii(0x1019_c6ea, 5); mov(eax, memd_a32[ds, 0x101b_7738]);    /* mov eax, [0x101b7738] */
            ii(0x1019_c6ef, 2); jmpd(0x1019_c70e, 0x1d); goto l_0x1019_c70e; /* jmp 0x1019c70e */
        l_0x1019_c6f1:
            ii(0x1019_c6f1, 4); fld(memq_a32[ss, esp + 0x20]);          /* fld qword [esp+0x20] */
            ii(0x1019_c6f5, 6); fcomp(memq_a32[ds, 0x101b_772c]);       /* fcomp qword [0x101b772c] */
            ii(0x1019_c6fb, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1019_c6fd, 1); sahf();                                 /* sahf */
            ii(0x1019_c6fe, 2); if(jnzd(0x1019_c712, 0x12)) goto l_0x1019_c712; /* jnz 0x1019c712 */
            ii(0x1019_c700, 5); mov(eax, memd_a32[ds, 0x101b_773c]);    /* mov eax, [0x101b773c] */
            ii(0x1019_c705, 4); mov(memd_a32[ss, esp + 0x20], eax);     /* mov [esp+0x20], eax */
            ii(0x1019_c709, 5); mov(eax, memd_a32[ds, 0x101b_7740]);    /* mov eax, [0x101b7740] */
        l_0x1019_c70e:
            ii(0x1019_c70e, 4); mov(memd_a32[ss, esp + 0x24], eax);     /* mov [esp+0x24], eax */
        l_0x1019_c712:
            ii(0x1019_c712, 5); mov(eax, 0x101b_7744);                  /* mov eax, 0x101b7744 */
            ii(0x1019_c717, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_c719, 2); if(jged(0x1019_c755, 0x3a)) goto l_0x1019_c755; /* jge 0x1019c755 */
            ii(0x1019_c71b, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1019_c71d, 2); neg(edx);                               /* neg edx */
            ii(0x1019_c71f, 6); cmp(edx, 0x134);                        /* cmp edx, 0x134 */
            ii(0x1019_c725, 2); if(jled(0x1019_c773, 0x4c)) goto l_0x1019_c773; /* jle 0x1019c773 */
            ii(0x1019_c727, 4); fld(memq_a32[ss, esp + 0x20]);          /* fld qword [esp+0x20] */
            ii(0x1019_c72b, 7); test(memb_a32[ds, 0x101b_e89c], 0x1);   /* test byte [0x101be89c], 0x1 */
            ii(0x1019_c732, 2); if(jzd(0x1019_c747, 0x13)) goto l_0x1019_c747; /* jz 0x1019c747 */
            ii(0x1019_c734, 6); pushd(memd_a32[ds, 0x101b_774a]);       /* push dword [0x101b774a] */
            ii(0x1019_c73a, 6); pushd(memd_a32[ds, 0x101b_7746]);       /* push dword [0x101b7746] */
            ii(0x1019_c740, 5); calld(/* sys */ 0x1018_78a8, -0x1_4e9d); /* call 0x101878a8 */
            ii(0x1019_c745, 2); jmpd(0x1019_c74d, 0x6); goto l_0x1019_c74d; /* jmp 0x1019c74d */
        l_0x1019_c747:
            ii(0x1019_c747, 6); fdiv(memq_a32[ds, 0x101b_7746]);        /* fdiv qword [0x101b7746] */
        l_0x1019_c74d:
            ii(0x1019_c74d, 6); sub(edx, 0xd8);                         /* sub edx, 0xd8 */
            ii(0x1019_c753, 2); jmpd(0x1019_c76f, 0x1a); goto l_0x1019_c76f; /* jmp 0x1019c76f */
        l_0x1019_c755:
            ii(0x1019_c755, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1019_c757, 6); cmp(ecx, 0x134);                        /* cmp ecx, 0x134 */
            ii(0x1019_c75d, 2); if(jled(0x1019_c773, 0x14)) goto l_0x1019_c773; /* jle 0x1019c773 */
            ii(0x1019_c75f, 4); fld(memq_a32[ss, esp + 0x20]);          /* fld qword [esp+0x20] */
            ii(0x1019_c763, 6); fmul(memq_a32[ds, 0x101b_7746]);        /* fmul qword [0x101b7746] */
            ii(0x1019_c769, 6); lea(edx, ecx - 0xd8);                   /* lea edx, [ecx-0xd8] */
        l_0x1019_c76f:
            ii(0x1019_c76f, 4); fstp(memq_a32[ss, esp + 0x20]);         /* fstp qword [esp+0x20] */
        l_0x1019_c773:
            ii(0x1019_c773, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_c775, 5); mov(esi, 0x3ff0_0000);                  /* mov esi, 0x3ff00000 */
            ii(0x1019_c77a, 3); mov(memd_a32[ss, esp], ebx);            /* mov [esp], ebx */
            ii(0x1019_c77d, 4); mov(memd_a32[ss, esp + 0x4], esi);      /* mov [esp+0x4], esi */
        l_0x1019_c781:
            ii(0x1019_c781, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1019_c784, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1019_c786, 2); if(jld(0x1019_c793, 0xb)) goto l_0x1019_c793; /* jl 0x1019c793 */
            ii(0x1019_c788, 3); fld(memq_a32[ss, esp]);                 /* fld qword [esp] */
            ii(0x1019_c78b, 3); fmul(memq_a32[ds, eax + 0x2]);          /* fmul qword [eax+0x2] */
            ii(0x1019_c78e, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1019_c790, 3); fstp(memq_a32[ss, esp]);                /* fstp qword [esp] */
        l_0x1019_c793:
            ii(0x1019_c793, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_c795, 2); if(jzd(0x1019_c7a4, 0xd)) goto l_0x1019_c7a4; /* jz 0x1019c7a4 */
            ii(0x1019_c797, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1019_c79a, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1019_c79d, 2); if(jzd(0x1019_c781, -0x1e)) goto l_0x1019_c781; /* jz 0x1019c781 */
            ii(0x1019_c79f, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1019_c7a2, 2); jmpd(0x1019_c781, -0x23); goto l_0x1019_c781; /* jmp 0x1019c781 */
        l_0x1019_c7a4:
            ii(0x1019_c7a4, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_c7a6, 2); if(jged(0x1019_c7c9, 0x21)) goto l_0x1019_c7c9; /* jge 0x1019c7c9 */
            ii(0x1019_c7a8, 4); fld(memq_a32[ss, esp + 0x20]);          /* fld qword [esp+0x20] */
            ii(0x1019_c7ac, 7); test(memb_a32[ds, 0x101b_e89c], 0x1);   /* test byte [0x101be89c], 0x1 */
            ii(0x1019_c7b3, 2); if(jzd(0x1019_c7c4, 0xf)) goto l_0x1019_c7c4; /* jz 0x1019c7c4 */
            ii(0x1019_c7b5, 4); pushd(memd_a32[ss, esp + 0x4]);         /* push dword [esp+0x4] */
            ii(0x1019_c7b9, 4); pushd(memd_a32[ss, esp + 0x4]);         /* push dword [esp+0x4] */
            ii(0x1019_c7bd, 5); calld(/* sys */ 0x1018_78a8, -0x1_4f1a); /* call 0x101878a8 */
            ii(0x1019_c7c2, 2); jmpd(0x1019_c7d0, 0xc); goto l_0x1019_c7d0; /* jmp 0x1019c7d0 */
        l_0x1019_c7c4:
            ii(0x1019_c7c4, 3); fdiv(memq_a32[ss, esp]);                /* fdiv qword [esp] */
            ii(0x1019_c7c7, 2); jmpd(0x1019_c7d0, 0x7); goto l_0x1019_c7d0; /* jmp 0x1019c7d0 */
        l_0x1019_c7c9:
            ii(0x1019_c7c9, 4); fld(memq_a32[ss, esp + 0x20]);          /* fld qword [esp+0x20] */
            ii(0x1019_c7cd, 3); fmul(memq_a32[ss, esp]);                /* fmul qword [esp] */
        l_0x1019_c7d0:
            ii(0x1019_c7d0, 4); fstp(memq_a32[ss, esp + 0x20]);         /* fstp qword [esp+0x20] */
            ii(0x1019_c7d4, 4); fld(memq_a32[ss, esp + 0x20]);          /* fld qword [esp+0x20] */
            ii(0x1019_c7d8, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_c7db, 1); popd(esi);                              /* pop esi */
            ii(0x1019_c7dc, 1); popd(edx);                              /* pop edx */
            ii(0x1019_c7dd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_c7de, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_c7df, 1); popd(eax);                              /* pop eax */
            ii(0x1019_c7e0, 3); retd(0xc);                              /* ret 0xc */
        }
    }
}
