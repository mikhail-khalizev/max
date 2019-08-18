using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_fa22-5e7a4475")]
        public void Method_100e_fa22()
        {
            ii(0x100e_fa22, 1); pushd(esi);                             /* push esi */
            ii(0x100e_fa23, 1); pushd(edi);                             /* push edi */
            ii(0x100e_fa24, 7); movzx(eax, memw_a32[ds, 0x101c_3652]);  /* movzx eax, word [0x101c3652] */
            ii(0x100e_fa2b, 6); mul(memd_a32[ds, 0x101c_364c]);         /* mul dword [0x101c364c] */
            ii(0x100e_fa31, 2); jmpd(0x100e_fa3e, 0xb); goto l_0x100e_fa3e; /* jmp 0x100efa3e */
        l_0x100e_fa33:
            ii(0x100e_fa33, 5); mov(eax, memd_a32[ds, 0x101b_86d0]);    /* mov eax, [0x101b86d0] */
            ii(0x100e_fa38, 6); add(eax, memd_a32[ds, 0x101c_364c]);    /* add eax, [0x101c364c] */
        l_0x100e_fa3e:
            ii(0x100e_fa3e, 5); mov(memd_a32[ds, 0x101b_86d0], eax);    /* mov [0x101b86d0], eax */
            ii(0x100e_fa43, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x100e_fa46, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_fa49, 6); mov(esi, memd_a32[ds, 0x101c_3634]);    /* mov esi, [0x101c3634] */
            ii(0x100e_fa4f, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100e_fa51, 2); mov(esi, memd_a32[ds, esi]);            /* mov esi, [esi] */
            ii(0x100e_fa53, 6); add(esi, memd_a32[ds, 0x101c_363c]);    /* add esi, [0x101c363c] */
            ii(0x100e_fa59, 6); mov(edi, memd_a32[ds, 0x101c_3638]);    /* mov edi, [0x101c3638] */
            ii(0x100e_fa5f, 9); mov(memw_a32[ds, 0x101b_86d4], 0);      /* mov word [0x101b86d4], 0x0 */
            ii(0x100e_fa68, 9); mov(memw_a32[ds, 0x101b_86d6], 0);      /* mov word [0x101b86d6], 0x0 */
            ii(0x100e_fa71, 6); mov(ax, memw_a32[ds, 0x101c_3650]);     /* mov ax, [0x101c3650] */
            ii(0x100e_fa77, 6); mov(memw_a32[ds, 0x101b_86d8], ax);     /* mov [0x101b86d8], ax */
            ii(0x100e_fa7d, 6); mov(ax, memw_a32[ds, 0x101c_3654]);     /* mov ax, [0x101c3654] */
            ii(0x100e_fa83, 6); mov(memw_a32[ds, 0x101b_86da], ax);     /* mov [0x101b86da], ax */
        l_0x100e_fa89:
            ii(0x100e_fa89, 3); movzx(eax, memw_a32[ds, esi]);          /* movzx eax, word [esi] */
            ii(0x100e_fa8c, 2); cmp(al, -0x1 /* 0xff */);               /* cmp al, 0xff */
            ii(0x100e_fa8e, 6); if(jzd(0x100e_fb9d, 0x109)) goto l_0x100e_fb9d; /* jz 0x100efb9d */
            ii(0x100e_fa94, 4); movzx(bx, ah);                          /* movzx bx, ah */
            ii(0x100e_fa98, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100e_fa9a, 1); inc(esi);                               /* inc esi */
            ii(0x100e_fa9b, 1); inc(esi);                               /* inc esi */
            ii(0x100e_fa9c, 7); add(memw_a32[ds, 0x101b_86d4], ax);     /* add [0x101b86d4], ax */
            ii(0x100e_faa3, 2); if(jzd(0x100e_faf9, 0x54)) goto l_0x100e_faf9; /* jz 0x100efaf9 */
            ii(0x100e_faa5, 6); mov(ax, memw_a32[ds, 0x101b_86d4]);     /* mov ax, [0x101b86d4] */
            ii(0x100e_faab, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_faae, 1); cdq();                                  /* cdq */
            ii(0x100e_faaf, 6); div(memd_a32[ds, 0x101c_3648]);         /* div dword [0x101c3648] */
            ii(0x100e_fab5, 2); inc(ax);                                /* inc ax */
            ii(0x100e_fab7, 7); sub(ax, memw_a32[ds, 0x101b_86d6]);     /* sub ax, [0x101b86d6] */
            ii(0x100e_fabe, 7); add(memw_a32[ds, 0x101b_86d6], ax);     /* add [0x101b86d6], ax */
            ii(0x100e_fac5, 8); cmp(memw_a32[ds, 0x101b_86d8], 0);      /* cmp word [0x101b86d8], 0x0 */
            ii(0x100e_facd, 2); if(jzd(0x100e_faea, 0x1b)) goto l_0x100e_faea; /* jz 0x100efaea */
            ii(0x100e_facf, 7); sub(memw_a32[ds, 0x101b_86d8], ax);     /* sub [0x101b86d8], ax */
            ii(0x100e_fad6, 2); if(jged(0x100e_faf9, 0x21)) goto l_0x100e_faf9; /* jge 0x100efaf9 */
            ii(0x100e_fad8, 6); mov(ax, memw_a32[ds, 0x101b_86d8]);     /* mov ax, [0x101b86d8] */
            ii(0x100e_fade, 3); neg(ax);                                /* neg ax */
            ii(0x100e_fae1, 9); mov(memw_a32[ds, 0x101b_86d8], 0);      /* mov word [0x101b86d8], 0x0 */
        l_0x100e_faea:
            ii(0x100e_faea, 7); sub(memw_a32[ds, 0x101b_86da], ax);     /* sub [0x101b86da], ax */
            ii(0x100e_faf1, 6); if(jled(0x100e_fb9d, 0xa6)) goto l_0x100e_fb9d; /* jle 0x100efb9d */
            ii(0x100e_faf7, 2); add(edi, eax);                          /* add edi, eax */
        l_0x100e_faf9:
            ii(0x100e_faf9, 7); add(memw_a32[ds, 0x101b_86d4], bx);     /* add [0x101b86d4], bx */
            ii(0x100e_fb00, 7); movzx(eax, memw_a32[ds, 0x101b_86d4]);  /* movzx eax, word [0x101b86d4] */
            ii(0x100e_fb07, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_fb0a, 1); cdq();                                  /* cdq */
            ii(0x100e_fb0b, 6); div(memd_a32[ds, 0x101c_3648]);         /* div dword [0x101c3648] */
            ii(0x100e_fb11, 2); inc(ax);                                /* inc ax */
            ii(0x100e_fb13, 7); sub(ax, memw_a32[ds, 0x101b_86d6]);     /* sub ax, [0x101b86d6] */
            ii(0x100e_fb1a, 7); add(memw_a32[ds, 0x101b_86d6], ax);     /* add [0x101b86d6], ax */
            ii(0x100e_fb21, 8); cmp(memw_a32[ds, 0x101b_86d8], 0);      /* cmp word [0x101b86d8], 0x0 */
            ii(0x100e_fb29, 2); if(jzd(0x100e_fb4a, 0x1f)) goto l_0x100e_fb4a; /* jz 0x100efb4a */
            ii(0x100e_fb2b, 7); sub(memw_a32[ds, 0x101b_86d8], ax);     /* sub [0x101b86d8], ax */
            ii(0x100e_fb32, 6); if(jged(0x100e_fa89, -0xaf)) goto l_0x100e_fa89; /* jge 0x100efa89 */
            ii(0x100e_fb38, 6); mov(ax, memw_a32[ds, 0x101b_86d8]);     /* mov ax, [0x101b86d8] */
            ii(0x100e_fb3e, 3); neg(ax);                                /* neg ax */
            ii(0x100e_fb41, 9); mov(memw_a32[ds, 0x101b_86d8], 0);      /* mov word [0x101b86d8], 0x0 */
        l_0x100e_fb4a:
            ii(0x100e_fb4a, 7); sub(memw_a32[ds, 0x101b_86da], ax);     /* sub [0x101b86da], ax */
            ii(0x100e_fb51, 2); if(jged(0x100e_fb63, 0x10)) goto l_0x100e_fb63; /* jge 0x100efb63 */
            ii(0x100e_fb53, 7); add(ax, memw_a32[ds, 0x101b_86da]);     /* add ax, [0x101b86da] */
            ii(0x100e_fb5a, 9); mov(memw_a32[ds, 0x101b_86da], 0);      /* mov word [0x101b86da], 0x0 */
        l_0x100e_fb63:
            ii(0x100e_fb63, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_fb65, 3); if(jcxzd(0x100e_fb98, 0x30)) goto l_0x100e_fb98; /* jcxz 0x100efb98 */
            ii(0x100e_fb68, 5); mov(eax, memd_a32[ds, 0x101c_945c]);    /* mov eax, [0x101c945c] */
            ii(0x100e_fb6d, 5); add(eax, 0x500);                        /* add eax, 0x500 */
            ii(0x100e_fb72, 6); add(edi, memd_a32[ds, 0x101c_9474]);    /* add edi, [0x101c9474] */
            ii(0x100e_fb78, 2); mov(bl, cl);                            /* mov bl, cl */
            ii(0x100e_fb7a, 3); shr(cx, 0x1);                           /* shr cx, 1 */
            ii(0x100e_fb7d, 4); adc(cx, 0);                             /* adc cx, 0x0 */
            ii(0x100e_fb81, 3); test(bl, 0x1);                          /* test bl, 0x1 */
            ii(0x100e_fb84, 2); if(jnzd(0x100e_fb8b, 0x5)) goto l_0x100e_fb8b; /* jnz 0x100efb8b */
        l_0x100e_fb86:
            ii(0x100e_fb86, 2); mov(al, memb_a32[ds, edi]);             /* mov al, [edi] */
            ii(0x100e_fb88, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_fb8a, 1); stosb_a32();                            /* stosb */
        l_0x100e_fb8b:
            ii(0x100e_fb8b, 2); mov(al, memb_a32[ds, edi]);             /* mov al, [edi] */
            ii(0x100e_fb8d, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_fb8f, 1); stosb_a32();                            /* stosb */
            ii(0x100e_fb90, 2); if(loopd_a32(0x100e_fb86, -0xc)) goto l_0x100e_fb86; /* loop 0x100efb86 */
            ii(0x100e_fb92, 6); sub(edi, memd_a32[ds, 0x101c_9474]);    /* sub edi, [0x101c9474] */
        l_0x100e_fb98:
            ii(0x100e_fb98, 5); jmpd(0x100e_fa89, -0x114); goto l_0x100e_fa89; /* jmp 0x100efa89 */
        l_0x100e_fb9d:
            ii(0x100e_fb9d, 7); movzx(eax, memw_a32[ds, 0x101b_7f5c]);  /* movzx eax, word [0x101b7f5c] */
            ii(0x100e_fba4, 6); add(memd_a32[ds, 0x101c_3638], eax);    /* add [0x101c3638], eax */
            ii(0x100e_fbaa, 7); dec(memw_a32[ds, 0x101c_3656]);         /* dec word [0x101c3656] */
            ii(0x100e_fbb1, 6); if(jnzd(0x100e_fa33, -0x184)) goto l_0x100e_fa33; /* jnz 0x100efa33 */
            ii(0x100e_fbb7, 1); popd(edi);                              /* pop edi */
            ii(0x100e_fbb8, 1); popd(esi);                              /* pop esi */
            ii(0x100e_fbb9, 1); retd(); return;                         /* ret */
        }
    }
}
