using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b336-ac542158")]
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
            ii(0x1015_b389, 5); calld(Definitions.my_get_res_data_by_id, -0x2_73b6); /* call 0x10133fd8 */
            ii(0x1015_b38e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_b390, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_b393, 3); mov(memd_a32[ds, eax + 0x27], edx);     /* mov [eax+0x27], edx */
            ii(0x1015_b396, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b39a, 3); imul(eax, eax, 0x2b);                   /* imul eax, eax, 0x2b */
            ii(0x1015_b39d, 6); mov(eax, memd_a32[ds, eax + 0x101c_94ef]); /* mov eax, [eax+0x101c94ef] */
            ii(0x1015_b3a3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_b3a6, 5); calld(Definitions.my_get_res_data_by_id, -0x2_73d3); /* call 0x10133fd8 */
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
            ii(0x1015_b3ff, 5); calld(0x1013_4157, -0x2_72ad);          /* call 0x10134157 */
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
            ii(0x1015_b446, 5); calld(0x1013_4157, -0x2_72f4);          /* call 0x10134157 */
        l_0x1015_b44b:
            ii(0x1015_b44b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b44e, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1015_b452, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_b455, 5); if(jmpd_func(0x1015_b704, 0x2aa)) return; /* jmp 0x1015b704 */
            ii(0x1015_b45a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b45d, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b04c); /* mov dword [eax+0xa], 0x101cb04c */
            ii(0x1015_b464, 5); if(jmpd_func(0x1015_b725, 0x2bc)) return; /* jmp 0x1015b725 */
            ii(0x1015_b469, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b46c, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b044); /* mov dword [eax+0xa], 0x101cb044 */
            ii(0x1015_b473, 5); if(jmpd_func(0x1015_b725, 0x2ad)) return; /* jmp 0x1015b725 */
            ii(0x1015_b478, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b47b, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b024); /* mov dword [eax+0xa], 0x101cb024 */
            ii(0x1015_b482, 5); if(jmpd_func(0x1015_b725, 0x29e)) return; /* jmp 0x1015b725 */
            ii(0x1015_b487, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b48a, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b02c); /* mov dword [eax+0xa], 0x101cb02c */
            ii(0x1015_b491, 5); if(jmpd_func(0x1015_b725, 0x28f)) return; /* jmp 0x1015b725 */
            ii(0x1015_b496, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b499, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b07c); /* mov dword [eax+0xa], 0x101cb07c */
            ii(0x1015_b4a0, 5); if(jmpd_func(0x1015_b725, 0x280)) return; /* jmp 0x1015b725 */
            ii(0x1015_b4a5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b4a8, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b054); /* mov dword [eax+0xa], 0x101cb054 */
            ii(0x1015_b4af, 5); if(jmpd_func(0x1015_b725, 0x271)) return; /* jmp 0x1015b725 */
            ii(0x1015_b4b4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b4b7, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b05c); /* mov dword [eax+0xa], 0x101cb05c */
            ii(0x1015_b4be, 5); if(jmpd_func(0x1015_b725, 0x262)) return; /* jmp 0x1015b725 */
            ii(0x1015_b4c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b4c6, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b064); /* mov dword [eax+0xa], 0x101cb064 */
            ii(0x1015_b4cd, 5); if(jmpd_func(0x1015_b725, 0x253)) return; /* jmp 0x1015b725 */
            ii(0x1015_b4d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b4d5, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b014); /* mov dword [eax+0xa], 0x101cb014 */
            ii(0x1015_b4dc, 5); if(jmpd_func(0x1015_b725, 0x244)) return; /* jmp 0x1015b725 */
            ii(0x1015_b4e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b4e4, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_affc); /* mov dword [eax+0xa], 0x101caffc */
            ii(0x1015_b4eb, 5); if(jmpd_func(0x1015_b725, 0x235)) return; /* jmp 0x1015b725 */
            ii(0x1015_b4f0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b4f3, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_aff4); /* mov dword [eax+0xa], 0x101caff4 */
            ii(0x1015_b4fa, 5); if(jmpd_func(0x1015_b725, 0x226)) return; /* jmp 0x1015b725 */
            ii(0x1015_b4ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b502, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b01c); /* mov dword [eax+0xa], 0x101cb01c */
            ii(0x1015_b509, 5); if(jmpd_func(0x1015_b725, 0x217)) return; /* jmp 0x1015b725 */
            ii(0x1015_b50e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b511, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b004); /* mov dword [eax+0xa], 0x101cb004 */
            ii(0x1015_b518, 5); if(jmpd_func(0x1015_b725, 0x208)) return; /* jmp 0x1015b725 */
            ii(0x1015_b51d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b520, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b034); /* mov dword [eax+0xa], 0x101cb034 */
            ii(0x1015_b527, 5); if(jmpd_func(0x1015_b725, 0x1f9)) return; /* jmp 0x1015b725 */
            ii(0x1015_b52c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b52f, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b03c); /* mov dword [eax+0xa], 0x101cb03c */
            ii(0x1015_b536, 5); if(jmpd_func(0x1015_b725, 0x1ea)) return; /* jmp 0x1015b725 */
            ii(0x1015_b53b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b53e, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b06c); /* mov dword [eax+0xa], 0x101cb06c */
            ii(0x1015_b545, 5); if(jmpd_func(0x1015_b725, 0x1db)) return; /* jmp 0x1015b725 */
            ii(0x1015_b54a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b54d, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b00c); /* mov dword [eax+0xa], 0x101cb00c */
            ii(0x1015_b554, 5); if(jmpd_func(0x1015_b725, 0x1cc)) return; /* jmp 0x1015b725 */
            ii(0x1015_b559, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b55c, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b074); /* mov dword [eax+0xa], 0x101cb074 */
            ii(0x1015_b563, 5); if(jmpd_func(0x1015_b725, 0x1bd)) return; /* jmp 0x1015b725 */
            ii(0x1015_b568, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b56b, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_afd4); /* mov dword [eax+0xa], 0x101cafd4 */
            ii(0x1015_b572, 5); if(jmpd_func(0x1015_b725, 0x1ae)) return; /* jmp 0x1015b725 */
            ii(0x1015_b577, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b57a, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_afdc); /* mov dword [eax+0xa], 0x101cafdc */
            ii(0x1015_b581, 5); if(jmpd_func(0x1015_b725, 0x19f)) return; /* jmp 0x1015b725 */
            ii(0x1015_b586, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b589, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_afe4); /* mov dword [eax+0xa], 0x101cafe4 */
            ii(0x1015_b590, 5); if(jmpd_func(0x1015_b725, 0x190)) return; /* jmp 0x1015b725 */
            ii(0x1015_b595, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b598, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_afec); /* mov dword [eax+0xa], 0x101cafec */
            ii(0x1015_b59f, 5); if(jmpd_func(0x1015_b725, 0x181)) return; /* jmp 0x1015b725 */
        }
    }
}
