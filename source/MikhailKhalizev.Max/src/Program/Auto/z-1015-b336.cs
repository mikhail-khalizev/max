using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c4311eae-b9d2-4cde-85bc-a6cc86376fc3")]
        public void Method_1015_b336()
        {
            ii(0x1015_b336, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1015_b33b, 5); calld(Definitions.sys_check_available_stack_size, 0xaa12); /* call 0x10165d52 */
            ii(0x1015_b340, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_b341, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_b342, 1); pushd(edx);                             /* push edx */
            ii(0x1015_b343, 1); pushd(esi);                             /* push esi */
            ii(0x1015_b344, 1); pushd(edi);                             /* push edi */
            ii(0x1015_b345, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_b346, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_b348, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_b34e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_b351, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b354, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1015_b358, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_b35b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b35f, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_b362, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x1015_b367, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_b369, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1015_b36c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b36f, 4); cmp(memd_a32[ds, eax + 0x27], 0);       /* cmp dword [eax+0x27], 0x0 */
            ii(0x1015_b373, 6); if(jnzd(0x1015_b44b, 0xd2)) goto l_0x1015_b44b; /* jnz 0x1015b44b */
            ii(0x1015_b379, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b37d, 3); imul(eax, eax, 0x2b);                   /* imul eax, eax, 0x2b */
            ii(0x1015_b380, 6); mov(eax, memd_a32[ds, eax + 0x101c_94ed]); /* mov eax, [eax+0x101c94ed] */
            ii(0x1015_b386, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_b389, 5); calld(Definitions.my_get_res_data_by_id, -0x273b6); /* call 0x10133fd8 */
            ii(0x1015_b38e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_b390, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b393, 3); mov(memd_a32[ds, eax + 0x27], edx);     /* mov [eax+0x27], edx */
            ii(0x1015_b396, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b39a, 3); imul(eax, eax, 0x2b);                   /* imul eax, eax, 0x2b */
            ii(0x1015_b39d, 6); mov(eax, memd_a32[ds, eax + 0x101c_94ef]); /* mov eax, [eax+0x101c94ef] */
            ii(0x1015_b3a3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_b3a6, 5); calld(Definitions.my_get_res_data_by_id, -0x273d3); /* call 0x10133fd8 */
            ii(0x1015_b3ab, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_b3ad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b3b0, 3); mov(memd_a32[ds, eax + 0x2b], edx);     /* mov [eax+0x2b], edx */
            ii(0x1015_b3b3, 7); cmp(memb_a32[ds, 0x101c_814a], 0);      /* cmp byte [0x101c814a], 0x0 */
            ii(0x1015_b3ba, 6); if(jzd(0x1015_b44b, 0x8b)) goto l_0x1015_b44b; /* jz 0x1015b44b */
            ii(0x1015_b3c0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b3c3, 4); cmp(memd_a32[ds, eax + 0x27], 0);       /* cmp dword [eax+0x27], 0x0 */
            ii(0x1015_b3c7, 2); if(jzd(0x1015_b404, 0x3b)) goto l_0x1015_b404; /* jz 0x1015b404 */
            ii(0x1015_b3c9, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1015_b3ce, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_b3d0, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1015_b3d3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b3d6, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x1015_b3d9, 5); calld(0x1015_aefb, -0x4e3);             /* call 0x1015aefb */
            ii(0x1015_b3de, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_b3e0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b3e3, 3); mov(memd_a32[ds, eax + 0x27], edx);     /* mov [eax+0x27], edx */
            ii(0x1015_b3e6, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1015_b3e9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b3ec, 3); mov(edx, memd_a32[ds, eax + 0x27]);     /* mov edx, [eax+0x27] */
            ii(0x1015_b3ef, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b3f3, 3); imul(eax, eax, 0x2b);                   /* imul eax, eax, 0x2b */
            ii(0x1015_b3f6, 6); mov(eax, memd_a32[ds, eax + 0x101c_94ed]); /* mov eax, [eax+0x101c94ed] */
            ii(0x1015_b3fc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_b3ff, 5); calld(0x1013_4157, -0x272ad);           /* call 0x10134157 */
        l_0x1015_b404:
            ii(0x1015_b404, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b407, 4); cmp(memd_a32[ds, eax + 0x2b], 0);       /* cmp dword [eax+0x2b], 0x0 */
            ii(0x1015_b40b, 2); if(jzd(0x1015_b44b, 0x3e)) goto l_0x1015_b44b; /* jz 0x1015b44b */
            ii(0x1015_b40d, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1015_b412, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_b417, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1015_b41a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b41d, 3); mov(eax, memd_a32[ds, eax + 0x2b]);     /* mov eax, [eax+0x2b] */
            ii(0x1015_b420, 5); calld(0x1015_aefb, -0x52a);             /* call 0x1015aefb */
            ii(0x1015_b425, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_b427, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b42a, 3); mov(memd_a32[ds, eax + 0x2b], edx);     /* mov [eax+0x2b], edx */
            ii(0x1015_b42d, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1015_b430, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b433, 3); mov(edx, memd_a32[ds, eax + 0x2b]);     /* mov edx, [eax+0x2b] */
            ii(0x1015_b436, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b43a, 3); imul(eax, eax, 0x2b);                   /* imul eax, eax, 0x2b */
            ii(0x1015_b43d, 6); mov(eax, memd_a32[ds, eax + 0x101c_94ef]); /* mov eax, [eax+0x101c94ef] */
            ii(0x1015_b443, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_b446, 5); calld(0x1013_4157, -0x272f4);           /* call 0x10134157 */
        l_0x1015_b44b:
            ii(0x1015_b44b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b44e, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1015_b452, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_b455, 5); jmpd(0x1015_b704, 0x2aa); goto l_0x1015_b704; /* jmp 0x1015b704 */
        //  ii(0x1015_b45a, 330); Недостижимый код.
l_0x1015_b5a4:
            ii(0x1015_b5a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b5a7, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_afcc); /* mov dword [eax+0xa], 0x101cafcc */
            ii(0x1015_b5ae, 5); jmpd(0x1015_b725, 0x172); goto l_0x1015_b725; /* jmp 0x1015b725 */
        //  ii(0x1015_b5b3, 337); Недостижимый код.
l_0x1015_b704:
            ii(0x1015_b704, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_b707, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_b70a, 5); cmp(memw_a32[ss, ebp - 0x18], 0x53);    /* cmp word [ebp-0x18], 0x53 */
            ii(0x1015_b70f, 6); if(jad(0x1015_b5a4, -0x171)) goto l_0x1015_b5a4; /* ja 0x1015b5a4 */
            ii(0x1015_b715, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_b717, 4); mov(ax, memw_a32[ss, ebp - 0x18]);      /* mov ax, [ebp-0x18] */
            ii(0x1015_b71b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_b71e, 7); jmpd_abs(memd_a32[cs, eax + 0x1015_b5b4]); return; /* jmp dword [cs:eax+0x1015b5b4] */
        l_0x1015_b725:
            ii(0x1015_b725, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b728, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1015_b72c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_b72f, 5); jmpd(0x1015_bca0, 0x56c); goto l_0x1015_bca0; /* jmp 0x1015bca0 */
        //  ii(0x1015_b734, 1035); Недостижимый код.
l_0x1015_bb3f:
            ii(0x1015_bb3f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_bb42, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_d924); /* mov dword [eax+0xe], 0x101bd924 */
            ii(0x1015_bb49, 5); jmpd(0x1015_bcc1, 0x173); goto l_0x1015_bcc1; /* jmp 0x1015bcc1 */
        //  ii(0x1015_bb4e, 338); Недостижимый код.
l_0x1015_bca0:
            ii(0x1015_bca0, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_bca3, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_bca6, 5); cmp(memw_a32[ss, ebp - 0x20], 0x53);    /* cmp word [ebp-0x20], 0x53 */
            ii(0x1015_bcab, 6); if(jad(0x1015_bb3f, -0x172)) goto l_0x1015_bb3f; /* ja 0x1015bb3f */
            ii(0x1015_bcb1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_bcb3, 4); mov(ax, memw_a32[ss, ebp - 0x20]);      /* mov ax, [ebp-0x20] */
            ii(0x1015_bcb7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_bcba, 7); jmpd_abs(memd_a32[cs, eax + 0x1015_bb50]); return; /* jmp dword [cs:eax+0x1015bb50] */
        l_0x1015_bcc1:
            ii(0x1015_bcc1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_bcc3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_bcc4, 1); popd(edi);                              /* pop edi */
            ii(0x1015_bcc5, 1); popd(esi);                              /* pop esi */
            ii(0x1015_bcc6, 1); popd(edx);                              /* pop edx */
            ii(0x1015_bcc7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_bcc8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_bcc9, 1); retd(); return;                         /* ret */
        }
    }
}
