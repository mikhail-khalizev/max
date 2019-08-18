using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bab7e3ff-0a20-4da9-b7de-ce49e53b4bdb")]
        public void /* sys */ Method_1017_0d58()
        {
            ii(0x1017_0d58, 1); pushd(esi);                             /* push esi */
            ii(0x1017_0d59, 1); pushd(edi);                             /* push edi */
            ii(0x1017_0d5a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_0d5b, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1017_0d5e, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_0d60, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1017_0d62, 2); mov(ebp, ebx);                          /* mov ebp, ebx */
            ii(0x1017_0d64, 4); mov(memd_a32[ss, esp + 0xc], ecx);      /* mov [esp+0xc], ecx */
            ii(0x1017_0d68, 5); mov(eax, memd_a32[ds, 0x101b_e1c0]);    /* mov eax, [0x101be1c0] */
            ii(0x1017_0d6d, 3); mov(edx, memd_a32[ds, eax + 0x3c]);     /* mov edx, [eax+0x3c] */
            ii(0x1017_0d70, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_0d72, 3); cmp(edx, 0xa);                          /* cmp edx, 0xa */
            ii(0x1017_0d75, 6); if(jged(0x1017_0f3b, 0x1c0)) goto l_0x1017_0f3b; /* jge 0x10170f3b */
            ii(0x1017_0d7b, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1017_0d7d, 5); calld(/* sys */ 0x1017_0fe4, 0x262);    /* call 0x10170fe4 */
            ii(0x1017_0d82, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_0d84, 6); if(jnzd(0x1017_0f3b, 0x1b1)) goto l_0x1017_0f3b; /* jnz 0x10170f3b */
            ii(0x1017_0d8a, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1017_0d8d, 7); lea(eax, edx * 8 + 0);                  /* lea eax, [edx*8] */
            ii(0x1017_0d94, 6); mov(ebx, memd_a32[ds, 0x101b_e1c0]);    /* mov ebx, [0x101be1c0] */
            ii(0x1017_0d9a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_0d9c, 3); add(ebx, 0x40);                         /* add ebx, 0x40 */
            ii(0x1017_0d9f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_0da2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_0da4, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_0da6, 5); mov(ebx, 0x24);                         /* mov ebx, 0x24 */
            ii(0x1017_0dab, 5); calld(Definitions.sys_memset, -0xafd0); /* call 0x10165de0 */
            ii(0x1017_0db0, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_0db3, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1017_0db7, 4); mov(ebx, memd_a32[ss, esp + 0x4]);      /* mov ebx, [esp+0x4] */
            ii(0x1017_0dbb, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1017_0dbe, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_0dc0, 6); mov(edx, memd_a32[ds, 0x101b_e1c0]);    /* mov edx, [0x101be1c0] */
            ii(0x1017_0dc6, 4); mov(memd_a32[ds, edx + eax * 4 + 0x40], edx); /* mov [edx+eax*4+0x40], edx */
            ii(0x1017_0dca, 3); lea(eax, edx + 0x40);                   /* lea eax, [edx+0x40] */
            ii(0x1017_0dcd, 4); mov(memd_a32[ss, esp + 0x8], eax);      /* mov [esp+0x8], eax */
            ii(0x1017_0dd1, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_0dd4, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1017_0dd8, 4); mov(ebx, memd_a32[ss, esp + 0x4]);      /* mov ebx, [esp+0x4] */
            ii(0x1017_0ddc, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1017_0ddf, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_0de1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_0de4, 4); mov(bl, memb_a32[ss, esp + 0xc]);       /* mov bl, [esp+0xc] */
            ii(0x1017_0de8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_0dea, 3); test(bl, 0x4);                          /* test bl, 0x4 */
            ii(0x1017_0ded, 2); if(jzd(0x1017_0e0c, 0x1d)) goto l_0x1017_0e0c; /* jz 0x10170e0c */
            ii(0x1017_0def, 3); mov(memd_a32[ds, eax + 0x4c], esi);     /* mov [eax+0x4c], esi */
            ii(0x1017_0df2, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1017_0df5, 7); lea(eax, edx * 8 + 0);                  /* lea eax, [edx*8] */
            ii(0x1017_0dfc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_0dfe, 4); mov(ecx, memd_a32[ss, esp + 0x8]);      /* mov ecx, [esp+0x8] */
            ii(0x1017_0e02, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_0e05, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1017_0e07, 5); jmpd(0x1017_0f3b, 0x12f); goto l_0x1017_0f3b; /* jmp 0x10170f3b */
        l_0x1017_0e0c:
            ii(0x1017_0e0c, 3); mov(memd_a32[ds, eax + 0x4c], ebp);     /* mov [eax+0x4c], ebp */
            ii(0x1017_0e0f, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_0e12, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1017_0e16, 4); mov(ebx, memd_a32[ss, esp + 0x4]);      /* mov ebx, [esp+0x4] */
            ii(0x1017_0e1a, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1017_0e1d, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_0e1f, 4); mov(memd_a32[ds, edx + eax * 4 + 0x50], ebp); /* mov [edx+eax*4+0x50], ebp */
            ii(0x1017_0e23, 4); mov(eax, memd_a32[ss, esp + 0xc]);      /* mov eax, [esp+0xc] */
            ii(0x1017_0e27, 5); and(eax, 0xf0);                         /* and eax, 0xf0 */
            ii(0x1017_0e2c, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1017_0e2f, 2); if(jbd(0x1017_0e41, 0x10)) goto l_0x1017_0e41; /* jb 0x10170e41 */
            ii(0x1017_0e31, 2); if(jbed(0x1017_0e84, 0x51)) goto l_0x1017_0e84; /* jbe 0x10170e84 */
            ii(0x1017_0e33, 3); cmp(eax, 0x40);                         /* cmp eax, 0x40 */
            ii(0x1017_0e36, 6); if(jzd(0x1017_0ec4, 0x88)) goto l_0x1017_0ec4; /* jz 0x10170ec4 */
            ii(0x1017_0e3c, 5); jmpd(0x1017_0f3b, 0xfa); goto l_0x1017_0f3b; /* jmp 0x10170f3b */
        l_0x1017_0e41:
            ii(0x1017_0e41, 3); cmp(eax, 0x10);                         /* cmp eax, 0x10 */
            ii(0x1017_0e44, 6); if(jnzd(0x1017_0f3b, 0xf1)) goto l_0x1017_0f3b; /* jnz 0x10170f3b */
            ii(0x1017_0e4a, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1017_0e4d, 7); lea(eax, ecx * 8 + 0);                  /* lea eax, [ecx*8] */
            ii(0x1017_0e54, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1017_0e56, 4); mov(memd_a32[ds, edx + eax * 4 + 0x5c], edi); /* mov [edx+eax*4+0x5c], edi */
            ii(0x1017_0e5a, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1017_0e5d, 7); lea(eax, ecx * 8 + 0);                  /* lea eax, [ecx*8] */
            ii(0x1017_0e64, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1017_0e66, 4); mov(memd_a32[ds, edx + eax * 4 + 0x60], edi); /* mov [edx+eax*4+0x60], edi */
            ii(0x1017_0e6a, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1017_0e6d, 7); lea(eax, edx * 8 + 0);                  /* lea eax, [edx*8] */
            ii(0x1017_0e74, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_0e76, 4); mov(ecx, memd_a32[ss, esp + 0x8]);      /* mov ecx, [esp+0x8] */
            ii(0x1017_0e7a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_0e7d, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1017_0e7f, 5); jmpd(0x1017_0f3b, 0xb7); goto l_0x1017_0f3b; /* jmp 0x10170f3b */
        l_0x1017_0e84:
            ii(0x1017_0e84, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_0e86, 5); calld(Definitions.sys_ftell, 0x18bc);   /* call 0x10172747 */
            ii(0x1017_0e8b, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1017_0e8e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_0e90, 7); lea(eax, ecx * 8 + 0);                  /* lea eax, [ecx*8] */
            ii(0x1017_0e97, 6); mov(ebx, memd_a32[ds, 0x101b_e1c0]);    /* mov ebx, [0x101be1c0] */
            ii(0x1017_0e9d, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1017_0e9f, 4); mov(memd_a32[ds, ebx + eax * 4 + 0x54], edx); /* mov [ebx+eax*4+0x54], edx */
            ii(0x1017_0ea3, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_0ea5, 5); calld(Definitions.sys_ftell, 0x189d);   /* call 0x10172747 */
            ii(0x1017_0eaa, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1017_0ead, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_0eaf, 7); lea(eax, ecx * 8 + 0);                  /* lea eax, [ecx*8] */
            ii(0x1017_0eb6, 6); mov(edx, memd_a32[ds, 0x101b_e1c0]);    /* mov edx, [0x101be1c0] */
            ii(0x1017_0ebc, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1017_0ebe, 4); mov(memd_a32[ds, edx + eax * 4 + 0x58], esi); /* mov [edx+eax*4+0x58], esi */
            ii(0x1017_0ec2, 2); jmpd(0x1017_0f26, 0x62); goto l_0x1017_0f26; /* jmp 0x10170f26 */
        l_0x1017_0ec4:
            ii(0x1017_0ec4, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_0ec6, 5); calld(Definitions.sys_ftell, 0x187c);   /* call 0x10172747 */
            ii(0x1017_0ecb, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1017_0ece, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_0ed0, 7); lea(eax, edx * 8 + 0);                  /* lea eax, [edx*8] */
            ii(0x1017_0ed7, 6); mov(ebx, memd_a32[ds, 0x101b_e1c0]);    /* mov ebx, [0x101be1c0] */
            ii(0x1017_0edd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_0edf, 4); mov(memd_a32[ds, ebx + eax * 4 + 0x54], ecx); /* mov [ebx+eax*4+0x54], ecx */
            ii(0x1017_0ee3, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_0ee5, 5); calld(Definitions.sys_ftell, 0x185d);   /* call 0x10172747 */
            ii(0x1017_0eea, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1017_0eed, 7); lea(esi, ecx * 8 + 0);                  /* lea esi, [ecx*8] */
            ii(0x1017_0ef4, 6); mov(edx, memd_a32[ds, 0x101b_e1c0]);    /* mov edx, [0x101be1c0] */
            ii(0x1017_0efa, 2); add(esi, ecx);                          /* add esi, ecx */
            ii(0x1017_0efc, 4); mov(memd_a32[ds, edx + esi * 4 + 0x58], eax); /* mov [edx+esi*4+0x58], eax */
            ii(0x1017_0f00, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_0f03, 7); lea(esi, eax * 8 + 0);                  /* lea esi, [eax*8] */
            ii(0x1017_0f0a, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1017_0f0c, 4); mov(memd_a32[ds, edx + esi * 4 + 0x5c], edi); /* mov [edx+esi*4+0x5c], edi */
            ii(0x1017_0f10, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_0f13, 7); lea(esi, eax * 8 + 0);                  /* lea esi, [eax*8] */
            ii(0x1017_0f1a, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1017_0f1c, 6); add(edi, 0x4000);                       /* add edi, 0x4000 */
            ii(0x1017_0f22, 4); mov(memd_a32[ds, edx + esi * 4 + 0x60], edi); /* mov [edx+esi*4+0x60], edi */
        l_0x1017_0f26:
            ii(0x1017_0f26, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1017_0f29, 7); lea(eax, ecx * 8 + 0);                  /* lea eax, [ecx*8] */
            ii(0x1017_0f30, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1017_0f32, 3); add(edx, 0x40);                         /* add edx, 0x40 */
            ii(0x1017_0f35, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_0f38, 3); lea(ecx, edx + eax);                    /* lea ecx, [edx+eax] */
        l_0x1017_0f3b:
            ii(0x1017_0f3b, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_0f3d, 2); if(jzd(0x1017_0f6d, 0x2e)) goto l_0x1017_0f6d; /* jz 0x10170f6d */
            ii(0x1017_0f3f, 3); mov(esi, memd_a32[ss, esp]);            /* mov esi, [esp] */
            ii(0x1017_0f42, 7); lea(eax, esi * 8 + 0);                  /* lea eax, [esi*8] */
            ii(0x1017_0f49, 6); mov(edx, memd_a32[ds, 0x101b_e1c0]);    /* mov edx, [0x101be1c0] */
            ii(0x1017_0f4f, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1017_0f51, 4); mov(ebx, memd_a32[ss, esp + 0xc]);      /* mov ebx, [esp+0xc] */
            ii(0x1017_0f55, 4); mov(memd_a32[ds, edx + eax * 4 + 0x44], ebx); /* mov [edx+eax*4+0x44], ebx */
            ii(0x1017_0f59, 3); mov(esi, memd_a32[ss, esp]);            /* mov esi, [esp] */
            ii(0x1017_0f5c, 7); lea(eax, esi * 8 + 0);                  /* lea eax, [esi*8] */
            ii(0x1017_0f63, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1017_0f65, 5); mov(memb_a32[ds, edx + eax * 4 + 0x48], 0x1); /* mov byte [edx+eax*4+0x48], 0x1 */
            ii(0x1017_0f6a, 3); inc(memd_a32[ds, edx + 0x3c]);          /* inc dword [edx+0x3c] */
        l_0x1017_0f6d:
            ii(0x1017_0f6d, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_0f6f, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1017_0f72, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_0f73, 1); popd(edi);                              /* pop edi */
            ii(0x1017_0f74, 1); popd(esi);                              /* pop esi */
            ii(0x1017_0f75, 1); retd(); return;                         /* ret */
        }
    }
}
