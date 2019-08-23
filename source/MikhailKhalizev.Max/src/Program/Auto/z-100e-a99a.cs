using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_a99a-c9ea90e7")]
        public void Method_100e_a99a()
        {
            ii(0x100e_a99a, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x100e_a99f, 5); calld(Definitions.sys_check_available_stack_size, 0x7_b3ae); /* call 0x10165d52 */
            ii(0x100e_a9a4, 1); pushd(esi);                             /* push esi */
            ii(0x100e_a9a5, 1); pushd(edi);                             /* push edi */
            ii(0x100e_a9a6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_a9a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a9a9, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100e_a9af, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_a9b2, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_a9b5, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100e_a9b8, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100e_a9bb, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
            ii(0x100e_a9c1, 1); inc(eax);                               /* inc eax */
            ii(0x100e_a9c2, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_a9c5, 6); calld_abs(memd_a32[ds, 0x101b_de08]);   /* call dword [0x101bde08] */
            ii(0x100e_a9cb, 1); inc(eax);                               /* inc eax */
            ii(0x100e_a9cc, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_a9cf, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_a9d2, 5); calld(Definitions.my_ctor_0x101b_4184, -0x7_3ee7); /* call 0x10076af0 */
            ii(0x100e_a9d7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_a9da, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_a9dd, 4); cmp(memb_a32[ss, ebp + 0x14], 0);       /* cmp byte [ebp+0x14], 0x0 */
            ii(0x100e_a9e1, 2); if(jzd(0x100e_aa0c, 0x29)) goto l_0x100e_aa0c; /* jz 0x100eaa0c */
            ii(0x100e_a9e3, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_a9e6, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x100e_a9ec, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x100e_a9f0, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_a9f2, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_a9f4, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_a9f7, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_a9f9, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_a9fb, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_a9fe, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_aa02, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_aa04, 2); if(jled(0x100e_aa0c, 0x6)) goto l_0x100e_aa0c; /* jle 0x100eaa0c */
            ii(0x100e_aa06, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_aa09, 3); add(memd_a32[ss, ebp - 0x8], eax);      /* add [ebp-0x8], eax */
        l_0x100e_aa0c:
            ii(0x100e_aa0c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_aa0f, 4); imul(eax, memd_a32[ss, ebp - 0x18]);    /* imul eax, [ebp-0x18] */
            ii(0x100e_aa13, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_aa16, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100e_aa1a, 5); calld(Definitions.sys_new_arr, 0x7_b5f1); /* call 0x10166010 */
            ii(0x100e_aa1f, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_aa22, 4); mov(memb_a32[ss, ebp - 0x2f], 0);       /* mov byte [ebp-0x2f], 0x0 */
        l_0x100e_aa26:
            ii(0x100e_aa26, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_aa29, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x100e_aa2c, 2); if(jzd(0x100e_aa36, 0x8)) goto l_0x100e_aa36; /* jz 0x100eaa36 */
            ii(0x100e_aa2e, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100e_aa32, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_aa34, 2); if(jgd(0x100e_aa3b, 0x5)) goto l_0x100e_aa3b; /* jg 0x100eaa3b */
        l_0x100e_aa36:
            ii(0x100e_aa36, 5); jmpd(0x100e_ab8d, 0x152); goto l_0x100e_ab8d; /* jmp 0x100eab8d */
        l_0x100e_aa3b:
            ii(0x100e_aa3b, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_aa3e, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
            ii(0x100e_aa41, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_aa43, 3); mov(memb_a32[ss, ebp - 0x30], al);      /* mov [ebp-0x30], al */
            ii(0x100e_aa46, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_aa48, 3); mov(al, memb_a32[ss, ebp - 0x30]);      /* mov al, [ebp-0x30] */
            ii(0x100e_aa4b, 6); calld_abs(memd_a32[ds, 0x101b_ddf8]);   /* call dword [0x101bddf8] */
            ii(0x100e_aa51, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_aa54, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100e_aa57, 3); sub(memd_a32[ss, ebp + 0x10], eax);     /* sub [ebp+0x10], eax */
            ii(0x100e_aa5a, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100e_aa5e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_aa60, 6); if(jld(0x100e_ab88, 0x122)) goto l_0x100e_ab88; /* jl 0x100eab88 */
            ii(0x100e_aa66, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x100e_aa6a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_aa6c, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_aa6f, 5); calld(Definitions.sys_memset, 0x7_b36c); /* call 0x10165de0 */
            ii(0x100e_aa74, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x100e_aa77, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_aa79, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_aa7e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_aa7f, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x100e_aa83, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_aa87, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100e_aa8a, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_aa8d, 6); calld_abs(memd_a32[ds, 0x101b_ddec]);   /* call dword [0x101bddec] */
            ii(0x100e_aa93, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
            ii(0x100e_aa99, 1); dec(eax);                               /* dec eax */
            ii(0x100e_aa9a, 4); mov(memw_a32[ss, ebp - 0x1a], ax);      /* mov [ebp-0x1a], ax */
            ii(0x100e_aa9e, 2); jmpd(0x100e_aaa7, 0x7); goto l_0x100e_aaa7; /* jmp 0x100eaaa7 */
        l_0x100e_aaa0:
            ii(0x100e_aaa0, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x100e_aaa3, 4); dec(memw_a32[ss, ebp - 0x1a]);          /* dec word [ebp-0x1a] */
        l_0x100e_aaa7:
            ii(0x100e_aaa7, 4); movsx(eax, memw_a32[ss, ebp - 0x1a]);   /* movsx eax, word [ebp-0x1a] */
            ii(0x100e_aaab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_aaad, 6); if(jld(0x100e_ab3b, 0x88)) goto l_0x100e_ab3b; /* jl 0x100eab3b */
            ii(0x100e_aab3, 4); movsx(edx, memw_a32[ss, ebp - 0x1a]);   /* movsx edx, word [ebp-0x1a] */
            ii(0x100e_aab7, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_aabb, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100e_aabe, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100e_aac1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_aac3, 3); mov(memd_a32[ss, ebp - 0x38], edx);     /* mov [ebp-0x38], edx */
            ii(0x100e_aac6, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_aaca, 3); add(eax, memd_a32[ss, ebp - 0x38]);     /* add eax, [ebp-0x38] */
            ii(0x100e_aacd, 1); inc(eax);                               /* inc eax */
            ii(0x100e_aace, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100e_aad1, 6); mov(memw_a32[ss, ebp - 0x1c], 0);       /* mov word [ebp-0x1c], 0x0 */
            ii(0x100e_aad7, 2); jmpd(0x100e_aae0, 0x7); goto l_0x100e_aae0; /* jmp 0x100eaae0 */
        l_0x100e_aad9:
            ii(0x100e_aad9, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_aadc, 4); inc(memw_a32[ss, ebp - 0x1c]);          /* inc word [ebp-0x1c] */
        l_0x100e_aae0:
            ii(0x100e_aae0, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_aae3, 4); cmp(ax, memw_a32[ss, ebp - 0x34]);      /* cmp ax, [ebp-0x34] */
            ii(0x100e_aae7, 2); if(jged(0x100e_ab36, 0x4d)) goto l_0x100e_ab36; /* jge 0x100eab36 */
            ii(0x100e_aae9, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100e_aaec, 3); inc(memd_a32[ss, ebp - 0x38]);          /* inc dword [ebp-0x38] */
            ii(0x100e_aaef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_aaf1, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x100e_aaf3, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x100e_aaf6, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_aaf8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_aafd, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_aaff, 2); if(jnzd(0x100e_ab2e, 0x2d)) goto l_0x100e_ab2e; /* jnz 0x100eab2e */
            ii(0x100e_ab01, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_ab04, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_ab06, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x100e_ab08, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x100e_ab0b, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_ab0d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_ab12, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_ab14, 2); if(jnzd(0x100e_ab23, 0xd)) goto l_0x100e_ab23; /* jnz 0x100eab23 */
            ii(0x100e_ab16, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x100e_ab19, 3); mov(dl, memb_a32[ds, eax + 0x1]);       /* mov dl, [eax+0x1] */
            ii(0x100e_ab1c, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_ab1f, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x100e_ab21, 2); jmpd(0x100e_ab2e, 0xb); goto l_0x100e_ab2e; /* jmp 0x100eab2e */
        l_0x100e_ab23:
            ii(0x100e_ab23, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x100e_ab26, 3); mov(dl, memb_a32[ds, eax + 0x2]);       /* mov dl, [eax+0x2] */
            ii(0x100e_ab29, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_ab2c, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
        l_0x100e_ab2e:
            ii(0x100e_ab2e, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_ab31, 3); inc(memd_a32[ss, ebp - 0x3c]);          /* inc dword [ebp-0x3c] */
            ii(0x100e_ab34, 2); jmpd(0x100e_aad9, -0x5d); goto l_0x100e_aad9; /* jmp 0x100eaad9 */
        l_0x100e_ab36:
            ii(0x100e_ab36, 5); jmpd(0x100e_aaa0, -0x9b); goto l_0x100e_aaa0; /* jmp 0x100eaaa0 */
        l_0x100e_ab3b:
            ii(0x100e_ab3b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_ab3e, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100e_ab41, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_ab44, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ab45, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_ab48, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100e_ab4b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_ab4e, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_ab52, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_ab55, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100e_ab57, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_ab5b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_ab5e, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x100e_ab61, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_ab63, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100e_ab65, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ab66, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_ab6a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ab6b, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_ab6f, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ab70, 4); movsx(eax, memw_a32[ss, ebp - 0x34]);   /* movsx eax, word [ebp-0x34] */
            ii(0x100e_ab74, 1); inc(eax);                               /* inc eax */
            ii(0x100e_ab75, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ab76, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_ab79, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ab7a, 5); calld(/* sys */ 0x1017_1e10, 0x8_7291); /* call 0x10171e10 */
            ii(0x100e_ab7f, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100e_ab82, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100e_ab85, 3); add(memd_a32[ss, ebp - 0x8], eax);      /* add [ebp-0x8], eax */
        l_0x100e_ab88:
            ii(0x100e_ab88, 5); jmpd(0x100e_aa26, -0x167); goto l_0x100e_aa26; /* jmp 0x100eaa26 */
        l_0x100e_ab8d:
            ii(0x100e_ab8d, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_ab90, 5); calld(Definitions.sys_delete, 0x7_b3cf); /* call 0x10165f64 */
            ii(0x100e_ab95, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_ab97, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_ab98, 1); popd(edi);                              /* pop edi */
            ii(0x100e_ab99, 1); popd(esi);                              /* pop esi */
            ii(0x100e_ab9a, 3); retd(0xc);                              /* ret 0xc */
        }
    }
}
