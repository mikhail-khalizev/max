using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_4b5f-34de7d9a")]
        public void Method_1013_4b5f()
        {
            ii(0x1013_4b5f, 5); pushd(0x8c);                            /* push 0x8c */
            ii(0x1013_4b64, 5); calld(Definitions.sys_check_available_stack_size, 0x3_11e9); /* call 0x10165d52 */
            ii(0x1013_4b69, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_4b6a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_4b6b, 1); pushd(edx);                             /* push edx */
            ii(0x1013_4b6c, 1); pushd(esi);                             /* push esi */
            ii(0x1013_4b6d, 1); pushd(edi);                             /* push edi */
            ii(0x1013_4b6e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_4b6f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_4b71, 6); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x1013_4b77, 5); mov(eax, 0x34b1);                       /* mov eax, 0x34b1 */
            ii(0x1013_4b7c, 5); calld(Definitions.sys_new_arr, 0x3_148f); /* call 0x10166010 */
            ii(0x1013_4b81, 5); mov(memd_a32[ds, Definitions.ptr_arr_meta_by_id], eax); /* mov [0x101c70ec], eax */
            ii(0x1013_4b86, 7); cmp(memd_a32[ds, Definitions.ptr_arr_meta_by_id], 0); /* cmp dword [0x101c70ec], 0x0 */
            ii(0x1013_4b8d, 2); if(jnzd(0x1013_4b98, 0x9)) goto l_0x1013_4b98; /* jnz 0x10134b98 */
            ii(0x1013_4b8f, 4); mov(memb_a32[ss, ebp - 0x8], 0x3);      /* mov byte [ebp-0x8], 0x3 */
            ii(0x1013_4b93, 5); jmpd(0x1013_4d04, 0x16c); goto l_0x1013_4d04; /* jmp 0x10134d04 */
        l_0x1013_4b98:
            ii(0x1013_4b98, 7); mov(memd_a32[ss, ebp - 0xc], 0x787);    /* mov dword [ebp-0xc], 0x787 */
        l_0x1013_4b9f:
            ii(0x1013_4b9f, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1013_4ba2, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1013_4ba7, 2); if(jzd(0x1013_4bd4, 0x2b)) goto l_0x1013_4bd4; /* jz 0x10134bd4 */
            ii(0x1013_4ba9, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_4bad, 3); imul(edx, eax, 0x7);                    /* imul edx, eax, 0x7 */
            ii(0x1013_4bb0, 5); mov(eax, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_4bb5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4bb7, 5); mov(memw_a32[ds, eax], 0xffff);         /* mov word [eax], 0xffff */
            ii(0x1013_4bbc, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_4bc0, 3); imul(eax, eax, 0x7);                    /* imul eax, eax, 0x7 */
            ii(0x1013_4bc3, 6); mov(edx, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov edx, [0x101c70ec] */
            ii(0x1013_4bc9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4bcb, 7); mov(memd_a32[ds, eax + 0x2], 0);        /* mov dword [eax+0x2], 0x0 */
            ii(0x1013_4bd2, 2); jmpd(0x1013_4b9f, -0x35); goto l_0x1013_4b9f; /* jmp 0x10134b9f */
        l_0x1013_4bd4:
            ii(0x1013_4bd4, 9); mov(memw_a32[ds, Definitions.ptr_end_arr_meta], 0); /* mov word [0x101c70da], 0x0 */
            ii(0x1013_4bdd, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1013_4be2, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1013_4be5, 5); calld(Definitions.sys_strcpy, 0x3_12e5); /* call 0x10165ecf */
            ii(0x1013_4bea, 5); mov(edx, StringDefinitions.PatchesRes); /* mov edx, 0x101a89fc */
            ii(0x1013_4bef, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1013_4bf2, 5); calld(Definitions.sys_strcat, 0x3_133a); /* call 0x10165f31 */
            ii(0x1013_4bf7, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1013_4bfa, 5); calld(Definitions.load_res_file, -0x28c); /* call 0x10134973 */
            ii(0x1013_4bff, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1013_4c02, 4); cmp(memb_a32[ss, ebp - 0x4], 0x6);      /* cmp byte [ebp-0x4], 0x6 */
            ii(0x1013_4c06, 2); if(jzd(0x1013_4c0e, 0x6)) goto l_0x1013_4c0e; /* jz 0x10134c0e */
            ii(0x1013_4c08, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_4c0c, 2); if(jnzd(0x1013_4c10, 0x2)) goto l_0x1013_4c10; /* jnz 0x10134c10 */
        l_0x1013_4c0e:
            ii(0x1013_4c0e, 2); jmpd(0x1013_4c1b, 0xb); goto l_0x1013_4c1b; /* jmp 0x10134c1b */
        l_0x1013_4c10:
            ii(0x1013_4c10, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_4c13, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1013_4c16, 5); jmpd(0x1013_4d04, 0xe9); goto l_0x1013_4d04; /* jmp 0x10134d04 */
        l_0x1013_4c1b:
            ii(0x1013_4c1b, 5); mov(edx, 0x101c_3dd4);                  /* mov edx, 0x101c3dd4 */
            ii(0x1013_4c20, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1013_4c23, 5); calld(Definitions.sys_strcpy, 0x3_12a7); /* call 0x10165ecf */
            ii(0x1013_4c28, 5); mov(edx, StringDefinitions.MaxRes);     /* mov edx, 0x101a8a08 */
            ii(0x1013_4c2d, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1013_4c30, 5); calld(Definitions.sys_strcat, 0x3_12fc); /* call 0x10165f31 */
            ii(0x1013_4c35, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1013_4c38, 5); calld(Definitions.load_res_file, -0x2ca); /* call 0x10134973 */
            ii(0x1013_4c3d, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1013_4c40, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_4c44, 2); if(jzd(0x1013_4c51, 0xb)) goto l_0x1013_4c51; /* jz 0x10134c51 */
            ii(0x1013_4c46, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_4c49, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1013_4c4c, 5); jmpd(0x1013_4d04, 0xb3); goto l_0x1013_4d04; /* jmp 0x10134d04 */
        l_0x1013_4c51:
            ii(0x1013_4c51, 5); mov(eax, 0x3100);                       /* mov eax, 0x3100 */
            ii(0x1013_4c56, 5); calld(Definitions.sys_new_arr, 0x3_13b5); /* call 0x10166010 */
            ii(0x1013_4c5b, 5); mov(memd_a32[ds, 0x101c_70e8], eax);    /* mov [0x101c70e8], eax */
            ii(0x1013_4c60, 7); cmp(memd_a32[ds, 0x101c_70e8], 0);      /* cmp dword [0x101c70e8], 0x0 */
            ii(0x1013_4c67, 2); if(jnzd(0x1013_4c72, 0x9)) goto l_0x1013_4c72; /* jnz 0x10134c72 */
            ii(0x1013_4c69, 4); mov(memb_a32[ss, ebp - 0x8], 0x3);      /* mov byte [ebp-0x8], 0x3 */
            ii(0x1013_4c6d, 5); jmpd(0x1013_4d04, 0x92); goto l_0x1013_4d04; /* jmp 0x10134d04 */
        l_0x1013_4c72:
            ii(0x1013_4c72, 5); mov(eax, 0x3100);                       /* mov eax, 0x3100 */
            ii(0x1013_4c77, 5); calld(Definitions.sys_new_arr, 0x3_1394); /* call 0x10166010 */
            ii(0x1013_4c7c, 5); mov(memd_a32[ds, 0x101c_70e0], eax);    /* mov [0x101c70e0], eax */
            ii(0x1013_4c81, 7); cmp(memd_a32[ds, 0x101c_70e0], 0);      /* cmp dword [0x101c70e0], 0x0 */
            ii(0x1013_4c88, 2); if(jnzd(0x1013_4c93, 0x9)) goto l_0x1013_4c93; /* jnz 0x10134c93 */
            ii(0x1013_4c8a, 4); mov(memb_a32[ss, ebp - 0x8], 0x3);      /* mov byte [ebp-0x8], 0x3 */
            ii(0x1013_4c8e, 5); jmpd(0x1013_4d04, 0x71); goto l_0x1013_4d04; /* jmp 0x10134d04 */
        l_0x1013_4c93:
            ii(0x1013_4c93, 5); mov(eax, 0x3100);                       /* mov eax, 0x3100 */
            ii(0x1013_4c98, 5); calld(Definitions.sys_new_arr, 0x3_1373); /* call 0x10166010 */
            ii(0x1013_4c9d, 5); mov(memd_a32[ds, 0x101c_70e4], eax);    /* mov [0x101c70e4], eax */
            ii(0x1013_4ca2, 7); cmp(memd_a32[ds, 0x101c_70e4], 0);      /* cmp dword [0x101c70e4], 0x0 */
            ii(0x1013_4ca9, 2); if(jnzd(0x1013_4cb1, 0x6)) goto l_0x1013_4cb1; /* jnz 0x10134cb1 */
            ii(0x1013_4cab, 4); mov(memb_a32[ss, ebp - 0x8], 0x3);      /* mov byte [ebp-0x8], 0x3 */
            ii(0x1013_4caf, 2); jmpd(0x1013_4d04, 0x53); goto l_0x1013_4d04; /* jmp 0x10134d04 */
        l_0x1013_4cb1:
            ii(0x1013_4cb1, 5); calld(0x1013_468c, -0x62a);             /* call 0x1013468c */
            ii(0x1013_4cb6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_4cb8, 2); if(jnzd(0x1013_4cc0, 0x6)) goto l_0x1013_4cc0; /* jnz 0x10134cc0 */
            ii(0x1013_4cba, 4); mov(memb_a32[ss, ebp - 0x8], 0x3);      /* mov byte [ebp-0x8], 0x3 */
            ii(0x1013_4cbe, 2); jmpd(0x1013_4d04, 0x44); goto l_0x1013_4d04; /* jmp 0x10134d04 */
        l_0x1013_4cc0:
            ii(0x1013_4cc0, 5); calld(0x1012_124a, -0x1_3a7b);          /* call 0x1012124a */
            ii(0x1013_4cc5, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_4ccc, 2); jmpd(0x1013_4cd4, 0x6); goto l_0x1013_4cd4; /* jmp 0x10134cd4 */
        l_0x1013_4cce:
            ii(0x1013_4cce, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_4cd1, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1013_4cd4:
            ii(0x1013_4cd4, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_4cd8, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1013_4cdb, 2); if(jged(0x1013_4d00, 0x23)) goto l_0x1013_4d00; /* jge 0x10134d00 */
            ii(0x1013_4cdd, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_4ce1, 3); imul(edx, edx, 0x2b);                   /* imul edx, edx, 0x2b */
            ii(0x1013_4ce4, 5); mov(eax, 0x101c_94c8);                  /* mov eax, 0x101c94c8 */
            ii(0x1013_4ce9, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_4ceb, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_4cef, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1013_4cf2, 5); mov(ebx, 0x101c_81c0);                  /* mov ebx, 0x101c81c0 */
            ii(0x1013_4cf7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_4cf9, 5); calld(0x100e_90e1, -0x4_bc1d);          /* call 0x100e90e1 */
            ii(0x1013_4cfe, 2); jmpd(0x1013_4cce, -0x32); goto l_0x1013_4cce; /* jmp 0x10134cce */
        l_0x1013_4d00:
            ii(0x1013_4d00, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1013_4d04:
            ii(0x1013_4d04, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1013_4d07, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_4d09, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_4d0a, 1); popd(edi);                              /* pop edi */
            ii(0x1013_4d0b, 1); popd(esi);                              /* pop esi */
            ii(0x1013_4d0c, 1); popd(edx);                              /* pop edx */
            ii(0x1013_4d0d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_4d0e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_4d0f, 1); retd(); return;                         /* ret */
        }
    }
}
