using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c83c7ec1-f294-40a6-ae7a-0aebddaa7d83")]
        public void /* sys */ Method_1018_bb60()
        {
            ii(0x1018_bb60, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_bb61, 1); pushd(esi);                             /* push esi */
            ii(0x1018_bb62, 1); pushd(edi);                             /* push edi */
            ii(0x1018_bb63, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_bb64, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1018_bb67, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1018_bb69, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1018_bb6b, 3); mov(memd_a32[ss, esp], ebx);            /* mov [esp], ebx */
            ii(0x1018_bb6e, 6); cmp(memd_a32[ds, edx], 0xfeba_feba);    /* cmp dword [edx], 0xfebafeba */
            ii(0x1018_bb74, 6); if(jnzd(0x1018_bce6, 0x16c)) goto l_0x1018_bce6; /* jnz 0x1018bce6 */
            ii(0x1018_bb7a, 3); mov(ebx, memd_a32[ds, esi + 0x4]);      /* mov ebx, [esi+0x4] */
            ii(0x1018_bb7d, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1018_bb7f, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_bb81, 2); if(jled(0x1018_bbb7, 0x34)) goto l_0x1018_bbb7; /* jle 0x1018bbb7 */
            ii(0x1018_bb83, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1018_bb85:
            ii(0x1018_bb85, 3); mov(eax, memd_a32[ds, esi + 0x20]);     /* mov eax, [esi+0x20] */
            ii(0x1018_bb88, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_bb8a, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1018_bb8c, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_bb8e, 2); if(jzd(0x1018_bb98, 0x8)) goto l_0x1018_bb98; /* jz 0x1018bb98 */
            ii(0x1018_bb90, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_bb92, 6); calld_abs(memd_a32[ds, 0x101b_e8b8]);   /* call dword [0x101be8b8] */ /* Вызов '0x1018_b5c0'. */
        l_0x1018_bb98:
            ii(0x1018_bb98, 3); mov(eax, memd_a32[ds, esi + 0x20]);     /* mov eax, [esi+0x20] */
            ii(0x1018_bb9b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_bb9d, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x1018_bba0, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_bba2, 2); if(jzd(0x1018_bbac, 0x8)) goto l_0x1018_bbac; /* jz 0x1018bbac */
            ii(0x1018_bba4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_bba6, 6); calld_abs(memd_a32[ds, 0x101b_e8b8]);   /* call dword [0x101be8b8] */ /* Вызов '0x1018_b5c0'. */
        l_0x1018_bbac:
            ii(0x1018_bbac, 1); inc(ebp);                               /* inc ebp */
            ii(0x1018_bbad, 3); mov(ecx, memd_a32[ds, esi + 0x4]);      /* mov ecx, [esi+0x4] */
            ii(0x1018_bbb0, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1018_bbb3, 2); cmp(ebp, ecx);                          /* cmp ebp, ecx */
            ii(0x1018_bbb5, 2); if(jld(0x1018_bb85, -0x32)) goto l_0x1018_bb85; /* jl 0x1018bb85 */
        l_0x1018_bbb7:
            ii(0x1018_bbb7, 3); mov(ebp, memd_a32[ds, esi + 0x20]);     /* mov ebp, [esi+0x20] */
            ii(0x1018_bbba, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1018_bbbc, 2); if(jzd(0x1018_bbc6, 0x8)) goto l_0x1018_bbc6; /* jz 0x1018bbc6 */
            ii(0x1018_bbbe, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1018_bbc0, 6); calld_abs(memd_a32[ds, 0x101b_e8b8]);   /* call dword [0x101be8b8] */ /* Вызов '0x1018_b5c0'. */
        l_0x1018_bbc6:
            ii(0x1018_bbc6, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1018_bbc8, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_bbca, 5); calld(/* sys */ 0x1018_bafc, -0xd3);    /* call 0x1018bafc */
            ii(0x1018_bbcf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bbd1, 6); if(jnzd(0x1018_bce6, 0x10f)) goto l_0x1018_bce6; /* jnz 0x1018bce6 */
            ii(0x1018_bbd7, 3); mov(memd_a32[ds, esi + 0x20], eax);     /* mov [esi+0x20], eax */
            ii(0x1018_bbda, 3); mov(eax, memd_a32[ds, esi + 0x8]);      /* mov eax, [esi+0x8] */
            ii(0x1018_bbdd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bbdf, 6); if(jled(0x1018_bce2, 0xfd)) goto l_0x1018_bce2; /* jle 0x1018bce2 */
            ii(0x1018_bbe5, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_bbe8, 6); calld_abs(memd_a32[ds, 0x101b_e8b0]);   /* call dword [0x101be8b0] */ /* Вызов '0x1018_b5b0'. */
            ii(0x1018_bbee, 3); mov(memd_a32[ds, esi + 0x20], eax);     /* mov [esi+0x20], eax */
            ii(0x1018_bbf1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bbf3, 6); if(jzd(0x1018_bce6, 0xed)) goto l_0x1018_bce6; /* jz 0x1018bce6 */
            ii(0x1018_bbf9, 3); mov(ebx, memd_a32[ds, esi + 0x4]);      /* mov ebx, [esi+0x4] */
            ii(0x1018_bbfc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_bbfe, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_bc00, 2); if(jled(0x1018_bc24, 0x22)) goto l_0x1018_bc24; /* jle 0x1018bc24 */
            ii(0x1018_bc02, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1018_bc04:
            ii(0x1018_bc04, 3); mov(ebx, memd_a32[ds, esi + 0x20]);     /* mov ebx, [esi+0x20] */
            ii(0x1018_bc07, 7); mov(memd_a32[ds, edx + ebx], 0);        /* mov dword [edx+ebx], 0x0 */
            ii(0x1018_bc0e, 3); mov(ebx, memd_a32[ds, esi + 0x20]);     /* mov ebx, [esi+0x20] */
            ii(0x1018_bc11, 8); mov(memd_a32[ds, edx + ebx + 0x4], 0);  /* mov dword [edx+ebx+0x4], 0x0 */
            ii(0x1018_bc19, 1); inc(eax);                               /* inc eax */
            ii(0x1018_bc1a, 3); mov(ecx, memd_a32[ds, esi + 0x4]);      /* mov ecx, [esi+0x4] */
            ii(0x1018_bc1d, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1018_bc20, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1018_bc22, 2); if(jld(0x1018_bc04, -0x20)) goto l_0x1018_bc04; /* jl 0x1018bc04 */
        l_0x1018_bc24:
            ii(0x1018_bc24, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1018_bc26, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1018_bc29, 4); mov(memd_a32[ss, esp + 0x4], ebp);      /* mov [esp+0x4], ebp */
            ii(0x1018_bc2d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bc2f, 6); if(jled(0x1018_bce2, 0xad)) goto l_0x1018_bce2; /* jle 0x1018bce2 */
        l_0x1018_bc35:
            ii(0x1018_bc35, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_bc37, 5); calld(/* sys */ 0x1017_1f05, -0x1_9d37); /* call 0x10171f05 */
            ii(0x1018_bc3c, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_bc3f, 6); if(jzd(0x1018_bceb, 0xa6)) goto l_0x1018_bceb; /* jz 0x1018bceb */
            ii(0x1018_bc45, 3); lea(edx, eax + 0x1);                    /* lea edx, [eax+0x1] */
            ii(0x1018_bc48, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_bc4a, 6); calld_abs(memd_a32[ds, 0x101b_e8b0]);   /* call dword [0x101be8b0] */ /* Вызов '0x1018_b5b0'. */
            ii(0x1018_bc50, 3); mov(ebx, memd_a32[ds, esi + 0x20]);     /* mov ebx, [esi+0x20] */
            ii(0x1018_bc53, 3); mov(memd_a32[ds, ebx + ebp], eax);      /* mov [ebx+ebp], eax */
            ii(0x1018_bc56, 3); mov(eax, memd_a32[ds, esi + 0x20]);     /* mov eax, [esi+0x20] */
            ii(0x1018_bc59, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1018_bc5b, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1018_bc5d, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_bc5f, 6); if(jzd(0x1018_bce6, 0x81)) goto l_0x1018_bce6; /* jz 0x1018bce6 */
            ii(0x1018_bc65, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_bc67, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1018_bc69, 5); calld(/* sys */ 0x1017_8fa7, -0x1_2cc7); /* call 0x10178fa7 */
            ii(0x1018_bc6e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bc70, 6); if(jzd(0x1018_bce6, 0x70)) goto l_0x1018_bce6; /* jz 0x1018bce6 */
            ii(0x1018_bc76, 3); mov(eax, memd_a32[ds, esi + 0xc]);      /* mov eax, [esi+0xc] */
            ii(0x1018_bc79, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bc7b, 2); if(jbed(0x1018_bccb, 0x4e)) goto l_0x1018_bccb; /* jbe 0x1018bccb */
            ii(0x1018_bc7d, 6); calld_abs(memd_a32[ds, 0x101b_e8b0]);   /* call dword [0x101be8b0] */ /* Вызов '0x1018_b5b0'. */
            ii(0x1018_bc83, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_bc85, 3); mov(eax, memd_a32[ds, esi + 0x20]);     /* mov eax, [esi+0x20] */
            ii(0x1018_bc88, 4); mov(memd_a32[ds, eax + ebp + 0x4], edx); /* mov [eax+ebp+0x4], edx */
            ii(0x1018_bc8c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_bc8e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bc90, 2); if(jzd(0x1018_bce6, 0x54)) goto l_0x1018_bce6; /* jz 0x1018bce6 */
            ii(0x1018_bc92, 4); cmp(memd_a32[ds, esi + 0x10], 0);       /* cmp dword [esi+0x10], 0x0 */
            ii(0x1018_bc96, 2); if(jzd(0x1018_bcb0, 0x18)) goto l_0x1018_bcb0; /* jz 0x1018bcb0 */
            ii(0x1018_bc98, 3); mov(eax, memd_a32[ds, esi + 0x20]);     /* mov eax, [esi+0x20] */
            ii(0x1018_bc9b, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1018_bc9e, 3); mov(ebx, memd_a32[ds, esi + 0xc]);      /* mov ebx, [esi+0xc] */
            ii(0x1018_bca1, 4); mov(edx, memd_a32[ds, eax + ebp + 0x4]); /* mov edx, [eax+ebp+0x4] */
            ii(0x1018_bca5, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_bca7, 3); calld_abs(memd_a32[ds, esi + 0x10]);    /* call dword [esi+0x10] */
            ii(0x1018_bcaa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bcac, 2); if(jzd(0x1018_bccb, 0x1d)) goto l_0x1018_bccb; /* jz 0x1018bccb */
            ii(0x1018_bcae, 2); jmpd(0x1018_bce6, 0x36); goto l_0x1018_bce6; /* jmp 0x1018bce6 */
        l_0x1018_bcb0:
            ii(0x1018_bcb0, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1018_bcb5, 3); mov(eax, memd_a32[ds, esi + 0x20]);     /* mov eax, [esi+0x20] */
            ii(0x1018_bcb8, 2); mov(ecx, edi);                          /* mov ecx, edi */
            ii(0x1018_bcba, 3); mov(edx, memd_a32[ds, esi + 0xc]);      /* mov edx, [esi+0xc] */
            ii(0x1018_bcbd, 4); mov(eax, memd_a32[ds, eax + ebp + 0x4]); /* mov eax, [eax+ebp+0x4] */
            ii(0x1018_bcc1, 5); calld(Definitions.sys_fread, -0x1_975a); /* call 0x1017256c */
            ii(0x1018_bcc6, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1018_bcc9, 2); if(jnzd(0x1018_bce6, 0x1b)) goto l_0x1018_bce6; /* jnz 0x1018bce6 */
        l_0x1018_bccb:
            ii(0x1018_bccb, 4); mov(edx, memd_a32[ss, esp + 0x4]);      /* mov edx, [esp+0x4] */
            ii(0x1018_bccf, 3); add(ebp, 0x8);                          /* add ebp, 0x8 */
            ii(0x1018_bcd2, 1); inc(edx);                               /* inc edx */
            ii(0x1018_bcd3, 3); mov(ebx, memd_a32[ds, esi + 0x4]);      /* mov ebx, [esi+0x4] */
            ii(0x1018_bcd6, 4); mov(memd_a32[ss, esp + 0x4], edx);      /* mov [esp+0x4], edx */
            ii(0x1018_bcda, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1018_bcdc, 6); if(jld(0x1018_bc35, -0xad)) goto l_0x1018_bc35; /* jl 0x1018bc35 */
        l_0x1018_bce2:
            ii(0x1018_bce2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_bce4, 2); jmpd(0x1018_bceb, 0x5); goto l_0x1018_bceb; /* jmp 0x1018bceb */
        l_0x1018_bce6:
            ii(0x1018_bce6, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1018_bceb:
            ii(0x1018_bceb, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1018_bcee, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_bcef, 1); popd(edi);                              /* pop edi */
            ii(0x1018_bcf0, 1); popd(esi);                              /* pop esi */
            ii(0x1018_bcf1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_bcf2, 1); retd(); return;                         /* ret */
        }
    }
}
