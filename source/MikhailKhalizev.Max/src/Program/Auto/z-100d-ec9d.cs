using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0e591c11-babf-4003-a1e3-2c9bc46ca0a0")]
        public void Method_100d_ec9d()
        {
            ii(0x100d_ec9d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100d_eca2, 5); calld(Definitions.sys_check_available_stack_size, 0x8_70ab); /* call 0x10165d52 */
            ii(0x100d_eca7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_eca8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_eca9, 1); pushd(edx);                             /* push edx */
            ii(0x100d_ecaa, 1); pushd(esi);                             /* push esi */
            ii(0x100d_ecab, 1); pushd(edi);                             /* push edi */
            ii(0x100d_ecac, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_ecad, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_ecaf, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_ecb5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_ecb8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ecbb, 5); calld(0x100d_ac00, -0x40c0);            /* call 0x100dac00 */
            ii(0x100d_ecc0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ecc3, 3); mov(edx, memd_a32[ds, eax + 0x49]);     /* mov edx, [eax+0x49] */
            ii(0x100d_ecc6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_ecc9, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100d_eccc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_eccf, 4); mov(ax, memw_a32[ds, eax + 0x4f]);      /* mov ax, [eax+0x4f] */
            ii(0x100d_ecd3, 7); mov(memw_a32[ds, edx + 0x101c_35c4], ax); /* mov [edx+0x101c35c4], ax */
            ii(0x100d_ecda, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ecdd, 7); mov(ax, memw_a32[ds, eax + 0x3e3]);     /* mov ax, [eax+0x3e3] */
            ii(0x100d_ece4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_ece7, 2); jmpd(0x100d_ecef, 0x6); goto l_0x100d_ecef; /* jmp 0x100decef */
        l_0x100d_ece9:
            ii(0x100d_ece9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ecec, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100d_ecef:
            ii(0x100d_ecef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ecf2, 5); add(eax, 0x3b3);                        /* add eax, 0x3b3 */
            ii(0x100d_ecf7, 5); calld(Definitions.my_2_get_count, -0x5_3994); /* call 0x1008b368 */
            ii(0x100d_ecfc, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100d_ed00, 2); if(jled(0x100d_ed5f, 0x5d)) goto l_0x100d_ed5f; /* jle 0x100ded5f */
            ii(0x100d_ed02, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ed05, 3); mov(ebx, memd_a32[ds, eax + 0x49]);     /* mov ebx, [eax+0x49] */
            ii(0x100d_ed08, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_ed0b, 6); imul(ebx, ebx, 0x247);                  /* imul ebx, ebx, 0x247 */
            ii(0x100d_ed11, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100d_ed15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ed18, 5); add(eax, 0x3b3);                        /* add eax, 0x3b3 */
            ii(0x100d_ed1d, 5); calld(0x1008_b228, -0x5_3afa);          /* call 0x1008b228 */
            ii(0x100d_ed22, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100d_ed25, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ed28, 3); mov(eax, memd_a32[ds, eax + 0x49]);     /* mov eax, [eax+0x49] */
            ii(0x100d_ed2b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_ed2e, 6); imul(ecx, eax, 0x247);                  /* imul ecx, eax, 0x247 */
            ii(0x100d_ed34, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100d_ed39, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100d_ed3b, 5); calld(0x100d_fd2c, 0xfec);              /* call 0x100dfd2c */
            ii(0x100d_ed40, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100d_ed42, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_ed47, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x100d_ed4c, 5); calld(0x1007_1e00, -0x6_cf51);          /* call 0x10071e00 */
            ii(0x100d_ed51, 5); imul(ax, memw_a32[ds, ecx + 0x8]);      /* imul ax, [ecx+0x8] */
            ii(0x100d_ed56, 7); sub(memw_a32[ds, ebx + 0x101c_a583], ax); /* sub [ebx+0x101ca583], ax */
            ii(0x100d_ed5d, 2); jmpd(0x100d_ece9, -0x76); goto l_0x100d_ece9; /* jmp 0x100dece9 */
        l_0x100d_ed5f:
            ii(0x100d_ed5f, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100d_ed66, 2); jmpd(0x100d_ed6e, 0x6); goto l_0x100d_ed6e; /* jmp 0x100ded6e */
        l_0x100d_ed68:
            ii(0x100d_ed68, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ed6b, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100d_ed6e:
            ii(0x100d_ed6e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ed71, 5); add(eax, 0x3b3);                        /* add eax, 0x3b3 */
            ii(0x100d_ed76, 5); calld(Definitions.my_2_get_count, -0x5_3a13); /* call 0x1008b368 */
            ii(0x100d_ed7b, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100d_ed7f, 2); if(jled(0x100d_ede6, 0x65)) goto l_0x100d_ede6; /* jle 0x100dede6 */
            ii(0x100d_ed81, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100d_ed85, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ed88, 5); add(eax, 0x3b7);                        /* add eax, 0x3b7 */
            ii(0x100d_ed8d, 5); calld(0x100e_08bc, 0x1b2a);             /* call 0x100e08bc */
            ii(0x100d_ed92, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100d_ed95, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_ed98, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100d_ed9c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_ed9e, 2); if(jnzd(0x100d_eda6, 0x6)) goto l_0x100d_eda6; /* jnz 0x100deda6 */
            ii(0x100d_eda0, 4); add(memd_a32[ss, ebp - 0xc], -0x28 /* 0xd8 */); /* add dword [ebp-0xc], 0xffffffd8 */
            ii(0x100d_eda4, 2); jmpd(0x100d_edb3, 0xd); goto l_0x100d_edb3; /* jmp 0x100dedb3 */
        l_0x100d_eda6:
            ii(0x100d_eda6, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100d_edaa, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100d_edad, 2); if(jnzd(0x100d_edb3, 0x4)) goto l_0x100d_edb3; /* jnz 0x100dedb3 */
            ii(0x100d_edaf, 4); add(memd_a32[ss, ebp - 0xc], -0x14 /* 0xec */); /* add dword [ebp-0xc], 0xffffffec */
        l_0x100d_edb3:
            ii(0x100d_edb3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_edb6, 3); mov(ebx, memd_a32[ds, edx + 0x49]);     /* mov ebx, [edx+0x49] */
            ii(0x100d_edb9, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_edbc, 6); imul(ebx, ebx, 0x247);                  /* imul ebx, ebx, 0x247 */
            ii(0x100d_edc2, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100d_edc6, 5); mov(ecx, 0x5);                          /* mov ecx, 0x5 */
            ii(0x100d_edcb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_edcd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_edd0, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x100d_edd2, 6); mov(edx, memd_a32[ds, ebx + 0x101c_a581]); /* mov edx, [ebx+0x101ca581] */
            ii(0x100d_edd8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_eddb, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_eddd, 7); mov(memw_a32[ds, ebx + 0x101c_a583], dx); /* mov [ebx+0x101ca583], dx */
            ii(0x100d_ede4, 2); jmpd(0x100d_ed68, -0x7e); goto l_0x100d_ed68; /* jmp 0x100ded68 */
        l_0x100d_ede6:
            ii(0x100d_ede6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_ede8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_ede9, 1); popd(edi);                              /* pop edi */
            ii(0x100d_edea, 1); popd(esi);                              /* pop esi */
            ii(0x100d_edeb, 1); popd(edx);                              /* pop edx */
            ii(0x100d_edec, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_eded, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_edee, 1); retd(); return;                         /* ret */
        }
    }
}
