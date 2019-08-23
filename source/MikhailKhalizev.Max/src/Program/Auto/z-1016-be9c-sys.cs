using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_be9c-2317e052")]
        public void /* sys */ Method_1016_be9c()
        {
            ii(0x1016_be9c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_be9d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_be9e, 1); pushd(edx);                             /* push edx */
            ii(0x1016_be9f, 1); pushd(esi);                             /* push esi */
            ii(0x1016_bea0, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_bea3, 7); cmp(memd_a32[ds, 0x101c_fbe8], 0);      /* cmp dword [0x101cfbe8], 0x0 */
            ii(0x1016_beaa, 6); if(jzd(0x1016_bfad, 0xfd)) goto l_0x1016_bfad; /* jz 0x1016bfad */
            ii(0x1016_beb0, 7); cmp(memd_a32[ds, 0x101c_fb90], 0);      /* cmp dword [0x101cfb90], 0x0 */
            ii(0x1016_beb7, 6); if(jnzd(0x1016_bfad, 0xf0)) goto l_0x1016_bfad; /* jnz 0x1016bfad */
            ii(0x1016_bebd, 6); mov(ecx, memd_a32[ds, 0x101c_fbd8]);    /* mov ecx, [0x101cfbd8] */
            ii(0x1016_bec3, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_bec5, 6); if(jnzd(0x1016_bfad, 0xe2)) goto l_0x1016_bfad; /* jnz 0x1016bfad */
            ii(0x1016_becb, 9); mov(memw_a32[ds, 0x101c_fbb4], 0x3);    /* mov word [0x101cfbb4], 0x3 */
            ii(0x1016_bed4, 5); mov(ebx, 0x101c_fb98);                  /* mov ebx, 0x101cfb98 */
            ii(0x1016_bed9, 5); mov(edx, 0x101c_fbb4);                  /* mov edx, 0x101cfbb4 */
            ii(0x1016_bede, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1016_bee3, 5); calld(/* sys */ 0x1016_c606, 0x71e);    /* call 0x1016c606 */
            ii(0x1016_bee8, 6); mov(ax, memw_a32[ds, 0x101c_fb9c]);     /* mov ax, [0x101cfb9c] */
            ii(0x1016_beee, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_bef0, 2); and(al, 0x3);                           /* and al, 0x3 */
            ii(0x1016_bef2, 5); mov(ebx, 0xb);                          /* mov ebx, 0xb */
            ii(0x1016_bef7, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1016_befa, 7); mov(memw_a32[ds, 0x101c_fbb4], bx);     /* mov [0x101cfbb4], bx */
            ii(0x1016_bf01, 5); mov(ebx, 0x101c_fb98);                  /* mov ebx, 0x101cfb98 */
            ii(0x1016_bf06, 5); mov(edx, 0x101c_fbb4);                  /* mov edx, 0x101cfbb4 */
            ii(0x1016_bf0b, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1016_bf10, 5); calld(/* sys */ 0x1016_c606, 0x6f1);    /* call 0x1016c606 */
            ii(0x1016_bf15, 7); movsx(eax, memw_a32[ds, 0x101c_fba0]);  /* movsx eax, word [0x101cfba0] */
            ii(0x1016_bf1c, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_bf1f, 7); movsx(eax, memw_a32[ds, 0x101c_fba4]);  /* movsx eax, word [0x101cfba4] */
            ii(0x1016_bf26, 6); fld(memq_a32[ds, 0x101b_de70]);         /* fld qword [0x101bde70] */
            ii(0x1016_bf2c, 3); fild(memd_a32[ss, esp]);                /* fild dword [esp] */
            ii(0x1016_bf2f, 2); fmul(ST(0), ST(1));                     /* fmul st0, st1 */
            ii(0x1016_bf31, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1016_bf35, 5); calld(Definitions.sys_round, -0x5ebc);  /* call 0x1016607e */
            ii(0x1016_bf3a, 3); fistp(memd_a32[ss, esp]);               /* fistp dword [esp] */
            ii(0x1016_bf3d, 4); fild(memd_a32[ss, esp + 0x4]);          /* fild dword [esp+0x4] */
            ii(0x1016_bf41, 2); fmulp(ST(1), ST(0));                    /* fmulp st1, st0 */
            ii(0x1016_bf43, 6); mov(esi, memd_a32[ds, 0x101b_e85c]);    /* mov esi, [0x101be85c] */
            ii(0x1016_bf49, 5); calld(Definitions.sys_round, -0x5ed0);  /* call 0x1016607e */
            ii(0x1016_bf4e, 4); fistp(memd_a32[ss, esp + 0x4]);         /* fistp dword [esp+0x4] */
            ii(0x1016_bf52, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1016_bf55, 3); setz(al);                               /* setz al */
            ii(0x1016_bf58, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_bf5d, 2); if(jzd(0x1016_bf9f, 0x40)) goto l_0x1016_bf9f; /* jz 0x1016bf9f */
            ii(0x1016_bf5f, 7); test(memb_a32[ds, 0x101b_e868], 0x4);   /* test byte [0x101be868], 0x4 */
            ii(0x1016_bf66, 2); if(jzd(0x1016_bf6c, 0x4)) goto l_0x1016_bf6c; /* jz 0x1016bf6c */
            ii(0x1016_bf68, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_bf6a, 2); if(jnzd(0x1016_bf82, 0x16)) goto l_0x1016_bf82; /* jnz 0x1016bf82 */
        l_0x1016_bf6c:
            ii(0x1016_bf6c, 7); test(memb_a32[ds, 0x101b_e868], 0x2);   /* test byte [0x101be868], 0x2 */
            ii(0x1016_bf73, 2); if(jzd(0x1016_bf93, 0x1e)) goto l_0x1016_bf93; /* jz 0x1016bf93 */
            ii(0x1016_bf75, 4); cmp(memd_a32[ss, esp], 0);              /* cmp dword [esp], 0x0 */
            ii(0x1016_bf79, 2); if(jnzd(0x1016_bf82, 0x7)) goto l_0x1016_bf82; /* jnz 0x1016bf82 */
            ii(0x1016_bf7b, 5); cmp(memd_a32[ss, esp + 0x4], 0);        /* cmp dword [esp+0x4], 0x0 */
            ii(0x1016_bf80, 2); if(jzd(0x1016_bf93, 0x11)) goto l_0x1016_bf93; /* jz 0x1016bf93 */
        l_0x1016_bf82:
            ii(0x1016_bf82, 10); mov(memd_a32[ds, 0x101b_e86c], 0x2);   /* mov dword [0x101be86c], 0x2 */
            ii(0x1016_bf8c, 5); calld(/* sys */ 0x1018_62e4, 0x1_a353); /* call 0x101862e4 */
            ii(0x1016_bf91, 2); jmpd(0x1016_bfad, 0x1a); goto l_0x1016_bfad; /* jmp 0x1016bfad */
        l_0x1016_bf93:
            ii(0x1016_bf93, 6); mov(ebx, memd_a32[ds, 0x101b_de7c]);    /* mov ebx, [0x101bde7c] */
            ii(0x1016_bf99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_bf9b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_bf9d, 2); jmpd(0x1016_bfa8, 0x9); goto l_0x1016_bfa8; /* jmp 0x1016bfa8 */
        l_0x1016_bf9f:
            ii(0x1016_bf9f, 4); mov(edx, memd_a32[ss, esp + 0x4]);      /* mov edx, [esp+0x4] */
            ii(0x1016_bfa3, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1016_bfa6, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
        l_0x1016_bfa8:
            ii(0x1016_bfa8, 5); calld(/* sys */ 0x1016_bfb8, 0xb);      /* call 0x1016bfb8 */
        l_0x1016_bfad:
            ii(0x1016_bfad, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_bfb0, 1); popd(esi);                              /* pop esi */
            ii(0x1016_bfb1, 1); popd(edx);                              /* pop edx */
            ii(0x1016_bfb2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_bfb3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_bfb4, 1); retd();                                 /* ret */
        }
    }
}
