using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("37faf781-0d50-48a6-a7d3-e0248f42fec4")]
        public void /* sys */ Method_1016_ced0()
        {
            ii(0x1016_ced0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_ced1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_ced2, 1); pushd(edx);                             /* push edx */
            ii(0x1016_ced3, 1); pushd(esi);                             /* push esi */
            ii(0x1016_ced4, 1); pushd(edi);                             /* push edi */
            ii(0x1016_ced5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_ced6, 3); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_ced9, 4); mov(memd_a32[ss, esp + 0x8], eax);      /* mov [esp+0x8], eax */
            ii(0x1016_cedd, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_cedf, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_cee1, 3); shl(ebx, 0x8);                          /* shl ebx, 0x8 */
        l_0x1016_cee4:
            ii(0x1016_cee4, 4); mov(eax, memd_a32[ss, esp + 0x8]);      /* mov eax, [esp+0x8] */
            ii(0x1016_cee8, 7); cmp(memb_a32[ds, eax + 0x101d_0420], 0); /* cmp byte [eax+0x101d0420], 0x0 */
            ii(0x1016_ceef, 2); if(jnzd(0x1016_cf0b, 0x1a)) goto l_0x1016_cf0b; /* jnz 0x1016cf0b */
            ii(0x1016_cef1, 7); cmp(memb_a32[ds, ecx + 0x101d_0420], 0); /* cmp byte [ecx+0x101d0420], 0x0 */
            ii(0x1016_cef8, 2); if(jzd(0x1016_cf14, 0x1a)) goto l_0x1016_cf14; /* jz 0x1016cf14 */
            ii(0x1016_cefa, 6); mov(memb_a32[ds, ebx + 0x101d_0520], cl); /* mov [ebx+0x101d0520], cl */
            ii(0x1016_cf00, 6); mov(memb_a32[ds, ebx + 0x101f_0520], cl); /* mov [ebx+0x101f0520], cl */
            ii(0x1016_cf06, 5); jmpd(0x1016_d0c2, 0x1b7); goto l_0x1016_d0c2; /* jmp 0x1016d0c2 */
        l_0x1016_cf0b:
            ii(0x1016_cf0b, 7); cmp(memb_a32[ds, ecx + 0x101d_0420], 0); /* cmp byte [ecx+0x101d0420], 0x0 */
            ii(0x1016_cf12, 2); if(jnzd(0x1016_cf23, 0xf)) goto l_0x1016_cf23; /* jnz 0x1016cf23 */
        l_0x1016_cf14:
            ii(0x1016_cf14, 4); mov(al, memb_a32[ss, esp + 0x8]);       /* mov al, [esp+0x8] */
            ii(0x1016_cf18, 6); mov(memb_a32[ds, ebx + 0x101d_0520], al); /* mov [ebx+0x101d0520], al */
            ii(0x1016_cf1e, 5); jmpd(0x1016_d0bc, 0x199); goto l_0x1016_d0bc; /* jmp 0x1016d0bc */
        l_0x1016_cf23:
            ii(0x1016_cf23, 5); movzx(edi, memb_a32[ss, esp + 0x8]);    /* movzx edi, byte [esp+0x8] */
            ii(0x1016_cf28, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_cf2a, 3); movzx(ebp, cl);                         /* movzx ebp, cl */
            ii(0x1016_cf2d, 5); calld(/* sys */ 0x1016_cae8, -0x44a);   /* call 0x1016cae8 */
            ii(0x1016_cf32, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_cf34, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_cf36, 6); and(edx, 0x7c00);                       /* and edx, 0x7c00 */
            ii(0x1016_cf3c, 5); calld(/* sys */ 0x1016_cae8, -0x459);   /* call 0x1016cae8 */
            ii(0x1016_cf41, 5); and(eax, 0x7c00);                       /* and eax, 0x7c00 */
            ii(0x1016_cf46, 3); sar(edx, 0xa);                          /* sar edx, 0xa */
            ii(0x1016_cf49, 3); sar(eax, 0xa);                          /* sar eax, 0xa */
            ii(0x1016_cf4c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_cf4e, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_cf50, 5); calld(/* sys */ 0x1016_cae8, -0x46d);   /* call 0x1016cae8 */
            ii(0x1016_cf55, 5); and(eax, 0x3e0);                        /* and eax, 0x3e0 */
            ii(0x1016_cf5a, 3); sar(eax, 0x5);                          /* sar eax, 0x5 */
            ii(0x1016_cf5d, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_cf60, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_cf62, 5); calld(/* sys */ 0x1016_cae8, -0x47f);   /* call 0x1016cae8 */
            ii(0x1016_cf67, 5); and(eax, 0x3e0);                        /* and eax, 0x3e0 */
            ii(0x1016_cf6c, 3); mov(esi, memd_a32[ss, esp]);            /* mov esi, [esp] */
            ii(0x1016_cf6f, 3); sar(eax, 0x5);                          /* sar eax, 0x5 */
            ii(0x1016_cf72, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_cf74, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_cf76, 5); calld(/* sys */ 0x1016_cae8, -0x493);   /* call 0x1016cae8 */
            ii(0x1016_cf7b, 3); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1016_cf7e, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_cf81, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_cf83, 3); mov(edi, memd_a32[ss, esp]);            /* mov edi, [esp] */
            ii(0x1016_cf86, 5); calld(/* sys */ 0x1016_cae8, -0x4a3);   /* call 0x1016cae8 */
            ii(0x1016_cf8b, 3); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1016_cf8e, 4); mov(memd_a32[ss, esp + 0x4], edx);      /* mov [esp+0x4], edx */
            ii(0x1016_cf92, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1016_cf94, 2); cmp(esi, edx);                          /* cmp esi, edx */
            ii(0x1016_cf96, 2); if(jled(0x1016_cf9c, 0x4)) goto l_0x1016_cf9c; /* jle 0x1016cf9c */
            ii(0x1016_cf98, 4); mov(memd_a32[ss, esp + 0x4], esi);      /* mov [esp+0x4], esi */
        l_0x1016_cf9c:
            ii(0x1016_cf9c, 4); cmp(eax, memd_a32[ss, esp + 0x4]);      /* cmp eax, [esp+0x4] */
            ii(0x1016_cfa0, 2); if(jled(0x1016_cfa6, 0x4)) goto l_0x1016_cfa6; /* jle 0x1016cfa6 */
            ii(0x1016_cfa2, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
        l_0x1016_cfa6:
            ii(0x1016_cfa6, 4); mov(edi, memd_a32[ss, esp + 0x4]);      /* mov edi, [esp+0x4] */
            ii(0x1016_cfaa, 3); cmp(edi, 0x1f);                         /* cmp edi, 0x1f */
            ii(0x1016_cfad, 2); if(jled(0x1016_d00f, 0x60)) goto l_0x1016_d00f; /* jle 0x1016d00f */
            ii(0x1016_cfaf, 3); sub(edi, 0x1f);                         /* sub edi, 0x1f */
            ii(0x1016_cfb2, 2); sub(edx, edi);                          /* sub edx, edi */
            ii(0x1016_cfb4, 2); sub(esi, edi);                          /* sub esi, edi */
            ii(0x1016_cfb6, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_cfb8, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_cfba, 2); if(jged(0x1016_cfbe, 0x2)) goto l_0x1016_cfbe; /* jge 0x1016cfbe */
            ii(0x1016_cfbc, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1016_cfbe:
            ii(0x1016_cfbe, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_cfc0, 2); if(jged(0x1016_cfc4, 0x2)) goto l_0x1016_cfc4; /* jge 0x1016cfc4 */
            ii(0x1016_cfc2, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1016_cfc4:
            ii(0x1016_cfc4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_cfc6, 2); if(jged(0x1016_cfca, 0x2)) goto l_0x1016_cfca; /* jge 0x1016cfca */
            ii(0x1016_cfc8, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_cfca:
            ii(0x1016_cfca, 3); shl(edx, 0xa);                          /* shl edx, 0xa */
            ii(0x1016_cfcd, 3); shl(esi, 0x5);                          /* shl esi, 0x5 */
            ii(0x1016_cfd0, 2); or(edx, esi);                           /* or edx, esi */
            ii(0x1016_cfd2, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1016_cfd4, 6); mov(al, memb_a32[ds, eax + 0x1020_0520]); /* mov al, [eax+0x10200520] */
            ii(0x1016_cfda, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_cfdf, 4); fild(memd_a32[ss, esp + 0x4]);          /* fild dword [esp+0x4] */
            ii(0x1016_cfe3, 6); fadd(memq_a32[ds, 0x101b_2e44]);        /* fadd qword [0x101b2e44] */
            ii(0x1016_cfe9, 6); fmul(memq_a32[ds, 0x101b_2e34]);        /* fmul qword [0x101b2e34] */
            ii(0x1016_cfef, 2); fld1();                                 /* fld1 */
            ii(0x1016_cff1, 2); faddp(1 /* st1 */, 0 /* st0 */);        /* faddp st1, st0 */
            ii(0x1016_cff3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_cff5, 6); fmul(memq_a32[ds, 0x101b_2e3c]);        /* fmul qword [0x101b2e3c] */
            ii(0x1016_cffb, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_cffd, 5); calld(Definitions.sys_round, -0x6f84);  /* call 0x1016607e */
            ii(0x1016_d002, 3); fistp(memd_a32[ss, esp]);               /* fistp dword [esp] */
            ii(0x1016_d005, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1016_d008, 5); calld(/* sys */ 0x1016_cab4, -0x559);   /* call 0x1016cab4 */
            ii(0x1016_d00d, 2); jmpd(0x1016_d024, 0x15); goto l_0x1016_d024; /* jmp 0x1016d024 */
        l_0x1016_d00f:
            ii(0x1016_d00f, 3); shl(edx, 0xa);                          /* shl edx, 0xa */
            ii(0x1016_d012, 3); shl(esi, 0x5);                          /* shl esi, 0x5 */
            ii(0x1016_d015, 2); or(edx, esi);                           /* or edx, esi */
            ii(0x1016_d017, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1016_d019, 6); mov(al, memb_a32[ds, eax + 0x1020_0520]); /* mov al, [eax+0x10200520] */
            ii(0x1016_d01f, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1016_d024:
            ii(0x1016_d024, 6); mov(memb_a32[ds, ebx + 0x101d_0520], al); /* mov [ebx+0x101d0520], al */
            ii(0x1016_d02a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_d02c, 4); mov(dl, memb_a32[ss, esp + 0x8]);       /* mov dl, [esp+0x8] */
            ii(0x1016_d030, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d032, 3); movzx(esi, cl);                         /* movzx esi, cl */
            ii(0x1016_d035, 5); calld(/* sys */ 0x1016_cae8, -0x552);   /* call 0x1016cae8 */
            ii(0x1016_d03a, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_d03c, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_d03e, 6); and(edi, 0x7c00);                       /* and edi, 0x7c00 */
            ii(0x1016_d044, 5); calld(/* sys */ 0x1016_cae8, -0x561);   /* call 0x1016cae8 */
            ii(0x1016_d049, 5); and(eax, 0x7c00);                       /* and eax, 0x7c00 */
            ii(0x1016_d04e, 3); sar(edi, 0xa);                          /* sar edi, 0xa */
            ii(0x1016_d051, 3); sar(eax, 0xa);                          /* sar eax, 0xa */
            ii(0x1016_d054, 3); imul(eax, edi);                         /* imul eax, edi */
            ii(0x1016_d057, 3); sar(eax, 0x5);                          /* sar eax, 0x5 */
            ii(0x1016_d05a, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_d05d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d05f, 5); calld(/* sys */ 0x1016_cae8, -0x57c);   /* call 0x1016cae8 */
            ii(0x1016_d064, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_d066, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_d068, 6); and(edi, 0x3e0);                        /* and edi, 0x3e0 */
            ii(0x1016_d06e, 5); calld(/* sys */ 0x1016_cae8, -0x58b);   /* call 0x1016cae8 */
            ii(0x1016_d073, 5); and(eax, 0x3e0);                        /* and eax, 0x3e0 */
            ii(0x1016_d078, 3); sar(edi, 0x5);                          /* sar edi, 0x5 */
            ii(0x1016_d07b, 3); sar(eax, 0x5);                          /* sar eax, 0x5 */
            ii(0x1016_d07e, 3); imul(edi, eax);                         /* imul edi, eax */
            ii(0x1016_d081, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d083, 5); calld(/* sys */ 0x1016_cae8, -0x5a0);   /* call 0x1016cae8 */
            ii(0x1016_d088, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_d08a, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_d08c, 5); calld(/* sys */ 0x1016_cae8, -0x5a9);   /* call 0x1016cae8 */
            ii(0x1016_d091, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_d093, 3); and(edx, 0x1f);                         /* and edx, 0x1f */
            ii(0x1016_d096, 3); and(esi, 0x1f);                         /* and esi, 0x1f */
            ii(0x1016_d099, 3); imul(esi, edx);                         /* imul esi, edx */
            ii(0x1016_d09c, 3); sar(edi, 0x5);                          /* sar edi, 0x5 */
            ii(0x1016_d09f, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1016_d0a2, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_d0a4, 3); shl(eax, 0xa);                          /* shl eax, 0xa */
            ii(0x1016_d0a7, 3); shl(edx, 0x5);                          /* shl edx, 0x5 */
            ii(0x1016_d0aa, 3); sar(esi, 0x5);                          /* sar esi, 0x5 */
            ii(0x1016_d0ad, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1016_d0af, 2); or(eax, esi);                           /* or eax, esi */
            ii(0x1016_d0b1, 6); mov(al, memb_a32[ds, eax + 0x1020_0520]); /* mov al, [eax+0x10200520] */
            ii(0x1016_d0b7, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1016_d0bc:
            ii(0x1016_d0bc, 6); mov(memb_a32[ds, ebx + 0x101f_0520], al); /* mov [ebx+0x101f0520], al */
        l_0x1016_d0c2:
            ii(0x1016_d0c2, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_d0c3, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_d0c4, 6); cmp(ecx, 0x100);                        /* cmp ecx, 0x100 */
            ii(0x1016_d0ca, 6); if(jld(0x1016_cee4, -0x1ec)) goto l_0x1016_cee4; /* jl 0x1016cee4 */
            ii(0x1016_d0d0, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1016_d0d3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_d0d4, 1); popd(edi);                              /* pop edi */
            ii(0x1016_d0d5, 1); popd(esi);                              /* pop esi */
            ii(0x1016_d0d6, 1); popd(edx);                              /* pop edx */
            ii(0x1016_d0d7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_d0d8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_d0d9, 1); retd(); return;                         /* ret */
        }
    }
}
