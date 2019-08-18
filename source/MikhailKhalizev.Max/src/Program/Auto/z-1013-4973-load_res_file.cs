using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_4973-db2e2f75")]
        public void load_res_file()
        {
            ii(0x1013_4973, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1013_4978, 5); calld(Definitions.sys_check_available_stack_size, 0x3_13d5); /* call 0x10165d52 */
            ii(0x1013_497d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_497e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_497f, 1); pushd(edx);                             /* push edx */
            ii(0x1013_4980, 1); pushd(esi);                             /* push esi */
            ii(0x1013_4981, 1); pushd(edi);                             /* push edi */
            ii(0x1013_4982, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_4983, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_4985, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1013_498b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_498e, 5); mov(edx, StringDefinitions.Rb7);        /* mov edx, 0x101a89f9 */
            ii(0x1013_4993, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_4996, 5); calld(Definitions.sys_fopen, 0x3_d9df); /* call 0x1017237a */
            ii(0x1013_499b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_499d, 6); mov(dl, memb_a32[ds, Definitions.ptr_end_arr_res_file]); /* mov dl, [0x101c70d8] */
            ii(0x1013_49a3, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1013_49a6, 6); mov(memd_a32[ds, edx + Definitions.arr_res_file], eax); /* mov [edx+0x101c70d0], eax */
            ii(0x1013_49ac, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_49ae, 5); mov(al, memb_a32[ds, Definitions.ptr_end_arr_res_file]); /* mov al, [0x101c70d8] */
            ii(0x1013_49b3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_49b6, 7); cmp(memd_a32[ds, eax + Definitions.arr_res_file], 0); /* cmp dword [eax+0x101c70d0], 0x0 */
            ii(0x1013_49bd, 2); if(jnzd(0x1013_49c8, 0x9)) goto l_0x1013_49c8; /* jnz 0x101349c8 */
            ii(0x1013_49bf, 4); mov(memb_a32[ss, ebp - 0x8], 0x6);      /* mov byte [ebp-0x8], 0x6 */
            ii(0x1013_49c3, 5); jmpd(0x1013_4b53, 0x18b); goto l_0x1013_4b53; /* jmp 0x10134b53 */
        l_0x1013_49c8:
            ii(0x1013_49c8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_49ca, 6); mov(bl, memb_a32[ds, Definitions.ptr_end_arr_res_file]); /* mov bl, [0x101c70d8] */
            ii(0x1013_49d0, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1013_49d3, 6); mov(ecx, memd_a32[ds, ebx + Definitions.arr_res_file]); /* mov ecx, [ebx+0x101c70d0] */
            ii(0x1013_49d9, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_49de, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1013_49e3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1013_49e6, 5); calld(Definitions.sys_fread, 0x3_db81); /* call 0x1017256c */
            ii(0x1013_49eb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_49ed, 2); if(jnzd(0x1013_49f8, 0x9)) goto l_0x1013_49f8; /* jnz 0x101349f8 */
            ii(0x1013_49ef, 4); mov(memb_a32[ss, ebp - 0x8], 0x7);      /* mov byte [ebp-0x8], 0x7 */
            ii(0x1013_49f3, 5); jmpd(0x1013_4b53, 0x15b); goto l_0x1013_4b53; /* jmp 0x10134b53 */
        l_0x1013_49f8:
            ii(0x1013_49f8, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1013_49fd, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1013_4a00, 5); mov(eax, 0x101b_b518);                  /* mov eax, 0x101bb518 */
            ii(0x1013_4a05, 5); calld(Definitions.sys_strncmp, 0x4_4752); /* call 0x1017915c */
            ii(0x1013_4a0a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_4a0c, 2); if(jzd(0x1013_4a17, 0x9)) goto l_0x1013_4a17; /* jz 0x10134a17 */
            ii(0x1013_4a0e, 4); mov(memb_a32[ss, ebp - 0x8], 0x8);      /* mov byte [ebp-0x8], 0x8 */
            ii(0x1013_4a12, 5); jmpd(0x1013_4b53, 0x13c); goto l_0x1013_4b53; /* jmp 0x10134b53 */
        l_0x1013_4a17:
            ii(0x1013_4a17, 7); cmp(memd_a32[ds, Definitions.ptr_arr_meta], 0); /* cmp dword [0x101c70f0], 0x0 */
            ii(0x1013_4a1e, 2); if(jnzd(0x1013_4a2f, 0xf)) goto l_0x1013_4a2f; /* jnz 0x10134a2f */
            ii(0x1013_4a20, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_4a23, 5); calld(Definitions.sys_new_arr, 0x3_15e8); /* call 0x10166010 */
            ii(0x1013_4a28, 5); mov(memd_a32[ds, Definitions.ptr_arr_meta], eax); /* mov [0x101c70f0], eax */
            ii(0x1013_4a2d, 2); jmpd(0x1013_4a4d, 0x1e); goto l_0x1013_4a4d; /* jmp 0x10134a4d */
        l_0x1013_4a2f:
            ii(0x1013_4a2f, 6); mov(edx, memd_a32[ds, Definitions.ptr_end_arr_res_file]); /* mov edx, [0x101c70d8] */
            ii(0x1013_4a35, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_4a38, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1013_4a3b, 3); add(edx, memd_a32[ss, ebp - 0x14]);     /* add edx, [ebp-0x14] */
            ii(0x1013_4a3e, 5); mov(eax, memd_a32[ds, Definitions.ptr_arr_meta]); /* mov eax, [0x101c70f0] */
            ii(0x1013_4a43, 5); calld(/* sys */ 0x1017_d776, 0x4_8d2e); /* call 0x1017d776 */
            ii(0x1013_4a48, 5); mov(memd_a32[ds, Definitions.ptr_arr_meta], eax); /* mov [0x101c70f0], eax */
        l_0x1013_4a4d:
            ii(0x1013_4a4d, 7); cmp(memd_a32[ds, Definitions.ptr_arr_meta], 0); /* cmp dword [0x101c70f0], 0x0 */
            ii(0x1013_4a54, 2); if(jnzd(0x1013_4a5f, 0x9)) goto l_0x1013_4a5f; /* jnz 0x10134a5f */
            ii(0x1013_4a56, 4); mov(memb_a32[ss, ebp - 0x8], 0x3);      /* mov byte [ebp-0x8], 0x3 */
            ii(0x1013_4a5a, 5); jmpd(0x1013_4b53, 0xf4); goto l_0x1013_4b53; /* jmp 0x10134b53 */
        l_0x1013_4a5f:
            ii(0x1013_4a5f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_4a61, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1013_4a64, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_4a66, 5); mov(al, memb_a32[ds, Definitions.ptr_end_arr_res_file]); /* mov al, [0x101c70d8] */
            ii(0x1013_4a6b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_4a6e, 6); mov(eax, memd_a32[ds, eax + Definitions.arr_res_file]); /* mov eax, [eax+0x101c70d0] */
            ii(0x1013_4a74, 5); calld(Definitions.sys_fseek, 0x3_d9f7); /* call 0x10172470 */
            ii(0x1013_4a79, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_4a7b, 5); mov(al, memb_a32[ds, Definitions.ptr_end_arr_res_file]); /* mov al, [0x101c70d8] */
            ii(0x1013_4a80, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_4a83, 6); mov(ecx, memd_a32[ds, eax + Definitions.arr_res_file]); /* mov ecx, [eax+0x101c70d0] */
            ii(0x1013_4a89, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_4a8e, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1013_4a91, 5); mov(eax, memd_a32[ds, Definitions.ptr_end_arr_res_file]); /* mov eax, [0x101c70d8] */
            ii(0x1013_4a96, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_4a99, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1013_4a9c, 6); mov(esi, memd_a32[ds, Definitions.ptr_arr_meta]); /* mov esi, [0x101c70f0] */
            ii(0x1013_4aa2, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1013_4aa4, 5); calld(Definitions.sys_fread, 0x3_dac3); /* call 0x1017256c */
            ii(0x1013_4aa9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_4aab, 2); if(jnzd(0x1013_4ab6, 0x9)) goto l_0x1013_4ab6; /* jnz 0x10134ab6 */
            ii(0x1013_4aad, 4); mov(memb_a32[ss, ebp - 0x8], 0x7);      /* mov byte [ebp-0x8], 0x7 */
            ii(0x1013_4ab1, 5); jmpd(0x1013_4b53, 0x9d); goto l_0x1013_4b53; /* jmp 0x10134b53 */
        l_0x1013_4ab6:
            ii(0x1013_4ab6, 6); mov(ax, memw_a32[ds, Definitions.ptr_end_arr_meta]); /* mov ax, [0x101c70da] */
            ii(0x1013_4abc, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_4abf, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1013_4ac2, 3); shr(edx, 0x4);                          /* shr edx, 0x4 */
            ii(0x1013_4ac5, 5); mov(eax, memd_a32[ds, Definitions.ptr_end_arr_res_file]); /* mov eax, [0x101c70d8] */
            ii(0x1013_4aca, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_4acd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4acf, 6); mov(memw_a32[ds, Definitions.ptr_end_arr_meta], ax); /* mov [0x101c70da], ax */
            ii(0x1013_4ad5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_4ad8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_4adb, 2); jmpd(0x1013_4ae3, 0x6); goto l_0x1013_4ae3; /* jmp 0x10134ae3 */
        l_0x1013_4add:
            ii(0x1013_4add, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_4ae0, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1013_4ae3:
            ii(0x1013_4ae3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_4ae6, 7); cmp(ax, memw_a32[ds, Definitions.ptr_end_arr_meta]); /* cmp ax, [0x101c70da] */
            ii(0x1013_4aed, 2); if(jged(0x1013_4b49, 0x5a)) goto l_0x1013_4b49; /* jge 0x10134b49 */
            ii(0x1013_4aef, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_4af3, 5); calld(0x1013_3bc5, -0xf33);             /* call 0x10133bc5 */
            ii(0x1013_4af8, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_4afb, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1013_4aff, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1013_4b02, 2); if(jzd(0x1013_4b1a, 0x16)) goto l_0x1013_4b1a; /* jz 0x10134b1a */
            ii(0x1013_4b04, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1013_4b08, 3); imul(edx, eax, 0x7);                    /* imul edx, eax, 0x7 */
            ii(0x1013_4b0b, 5); mov(eax, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_4b10, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4b12, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1013_4b15, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1013_4b18, 2); if(jzd(0x1013_4b1c, 0x2)) goto l_0x1013_4b1c; /* jz 0x10134b1c */
        l_0x1013_4b1a:
            ii(0x1013_4b1a, 2); jmpd(0x1013_4b47, 0x2b); goto l_0x1013_4b47; /* jmp 0x10134b47 */
        l_0x1013_4b1c:
            ii(0x1013_4b1c, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1013_4b20, 3); imul(edx, edx, 0x7);                    /* imul edx, edx, 0x7 */
            ii(0x1013_4b23, 5); mov(eax, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_4b28, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_4b2a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_4b2d, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1013_4b30, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1013_4b34, 3); imul(eax, eax, 0x7);                    /* imul eax, eax, 0x7 */
            ii(0x1013_4b37, 6); mov(edx, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov edx, [0x101c70ec] */
            ii(0x1013_4b3d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_4b3f, 5); mov(al, memb_a32[ds, Definitions.ptr_end_arr_res_file]); /* mov al, [0x101c70d8] */
            ii(0x1013_4b44, 3); mov(memb_a32[ds, edx + 0x6], al);       /* mov [edx+0x6], al */
        l_0x1013_4b47:
            ii(0x1013_4b47, 2); jmpd(0x1013_4add, -0x6c); goto l_0x1013_4add; /* jmp 0x10134add */
        l_0x1013_4b49:
            ii(0x1013_4b49, 6); inc(memb_a32[ds, Definitions.ptr_end_arr_res_file]); /* inc byte [0x101c70d8] */
            ii(0x1013_4b4f, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1013_4b53:
            ii(0x1013_4b53, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1013_4b56, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_4b58, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_4b59, 1); popd(edi);                              /* pop edi */
            ii(0x1013_4b5a, 1); popd(esi);                              /* pop esi */
            ii(0x1013_4b5b, 1); popd(edx);                              /* pop edx */
            ii(0x1013_4b5c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_4b5d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_4b5e, 1); retd(); return;                         /* ret */
        }
    }
}
