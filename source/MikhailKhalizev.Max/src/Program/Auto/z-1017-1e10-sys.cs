using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a5fb2d0f-8955-4bca-90ec-48bcb84e4542")]
        public void /* sys */ Method_1017_1e10()
        {
            ii(0x1017_1e10, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_1e11, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_1e13, 1); pushd(eax);                             /* push eax */
            ii(0x1017_1e14, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_1e15, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_1e16, 1); pushd(edx);                             /* push edx */
            ii(0x1017_1e17, 1); pushd(esi);                             /* push esi */
            ii(0x1017_1e18, 1); pushd(edi);                             /* push edi */
            ii(0x1017_1e19, 3); mov(ecx, memd_a32[ss, ebp + 0xc]);      /* mov ecx, [ebp+0xc] */
            ii(0x1017_1e1c, 2); or(ecx, ecx);                           /* or ecx, ecx */
            ii(0x1017_1e1e, 6); if(jzd(0x1017_1ebf, 0x9b)) goto l_0x1017_1ebf; /* jz 0x10171ebf */
            ii(0x1017_1e24, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x1017_1e27, 2); mov(ah, 0);                             /* mov ah, 0x0 */
            ii(0x1017_1e29, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1017_1e2c, 3); mov(edi, memd_a32[ss, ebp + 0x18]);     /* mov edi, [ebp+0x18] */
            ii(0x1017_1e2f, 3); sub(memd_a32[ss, ebp + 0x1c], ecx);     /* sub [ebp+0x1c], ecx */
            ii(0x1017_1e32, 3); sub(memd_a32[ss, ebp + 0x14], ecx);     /* sub [ebp+0x14], ecx */
            ii(0x1017_1e35, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1017_1e37, 1); nop();                                  /* nop */
        l_0x1017_1e38:
            ii(0x1017_1e38, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1017_1e3a, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1017_1e3d, 2); if(jzd(0x1017_1e9c, 0x5d)) goto l_0x1017_1e9c; /* jz 0x10171e9c */
            ii(0x1017_1e3f, 1); nop();                                  /* nop */
        l_0x1017_1e40:
            ii(0x1017_1e40, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1017_1e42, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1017_1e44, 2); if(jnzd(0x1017_1e6e, 0x28)) goto l_0x1017_1e6e; /* jnz 0x10171e6e */
        l_0x1017_1e46:
            ii(0x1017_1e46, 3); mov(al, memb_a32[ds, esi + 0x1]);       /* mov al, [esi+0x1] */
            ii(0x1017_1e49, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1017_1e4b, 2); if(jnzd(0x1017_1e77, 0x2a)) goto l_0x1017_1e77; /* jnz 0x10171e77 */
        l_0x1017_1e4d:
            ii(0x1017_1e4d, 3); mov(al, memb_a32[ds, esi + 0x2]);       /* mov al, [esi+0x2] */
            ii(0x1017_1e50, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1017_1e52, 2); if(jnzd(0x1017_1e81, 0x2d)) goto l_0x1017_1e81; /* jnz 0x10171e81 */
        l_0x1017_1e54:
            ii(0x1017_1e54, 3); mov(al, memb_a32[ds, esi + 0x3]);       /* mov al, [esi+0x3] */
            ii(0x1017_1e57, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1017_1e59, 2); if(jnzd(0x1017_1e8b, 0x30)) goto l_0x1017_1e8b; /* jnz 0x10171e8b */
        l_0x1017_1e5b:
            ii(0x1017_1e5b, 3); add(edi, 0x4);                          /* add edi, 0x4 */
            ii(0x1017_1e5e, 3); add(esi, 0x4);                          /* add esi, 0x4 */
            ii(0x1017_1e61, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_1e62, 2); if(jnzd(0x1017_1e40, -0x24)) goto l_0x1017_1e40; /* jnz 0x10171e40 */
            ii(0x1017_1e64, 2); if(jzd(0x1017_1e9c, 0x36)) goto l_0x1017_1e9c; /* jz 0x10171e9c */
            ii(0x1017_1e66, 2); mov(eax, eax);                          /* mov eax, eax */
        l_0x1017_1e68:
            ii(0x1017_1e68, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1017_1e6a, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1017_1e6c, 2); if(jzd(0x1017_1e46, -0x28)) goto l_0x1017_1e46; /* jz 0x10171e46 */
        l_0x1017_1e6e:
            ii(0x1017_1e6e, 2); mov(memb_a32[ds, edi], al);             /* mov [edi], al */
            ii(0x1017_1e70, 3); mov(al, memb_a32[ds, esi + 0x1]);       /* mov al, [esi+0x1] */
            ii(0x1017_1e73, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1017_1e75, 2); if(jzd(0x1017_1e4d, -0x2a)) goto l_0x1017_1e4d; /* jz 0x10171e4d */
        l_0x1017_1e77:
            ii(0x1017_1e77, 3); mov(memb_a32[ds, edi + 0x1], al);       /* mov [edi+0x1], al */
            ii(0x1017_1e7a, 3); mov(al, memb_a32[ds, esi + 0x2]);       /* mov al, [esi+0x2] */
            ii(0x1017_1e7d, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1017_1e7f, 2); if(jzd(0x1017_1e54, -0x2d)) goto l_0x1017_1e54; /* jz 0x10171e54 */
        l_0x1017_1e81:
            ii(0x1017_1e81, 3); mov(memb_a32[ds, edi + 0x2], al);       /* mov [edi+0x2], al */
            ii(0x1017_1e84, 3); mov(al, memb_a32[ds, esi + 0x3]);       /* mov al, [esi+0x3] */
            ii(0x1017_1e87, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1017_1e89, 2); if(jzd(0x1017_1e5b, -0x30)) goto l_0x1017_1e5b; /* jz 0x10171e5b */
        l_0x1017_1e8b:
            ii(0x1017_1e8b, 3); mov(memb_a32[ds, edi + 0x3], al);       /* mov [edi+0x3], al */
            ii(0x1017_1e8e, 3); add(edi, 0x4);                          /* add edi, 0x4 */
            ii(0x1017_1e91, 3); add(esi, 0x4);                          /* add esi, 0x4 */
            ii(0x1017_1e94, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_1e95, 2); if(jnzd(0x1017_1e68, -0x2f)) goto l_0x1017_1e68; /* jnz 0x10171e68 */
            ii(0x1017_1e97, 2); if(jzd(0x1017_1e9c, 0x3)) goto l_0x1017_1e9c; /* jz 0x10171e9c */
            ii(0x1017_1e99, 3); mov(eax, eax);                          /* mov eax, eax */
        l_0x1017_1e9c:
            ii(0x1017_1e9c, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1017_1e9e, 3); and(ecx, 0x3);                          /* and ecx, 0x3 */
            ii(0x1017_1ea1, 2); if(jnzd(0x1017_1eae, 0xb)) goto l_0x1017_1eae; /* jnz 0x10171eae */
        l_0x1017_1ea3:
            ii(0x1017_1ea3, 3); add(esi, memd_a32[ss, ebp + 0x14]);     /* add esi, [ebp+0x14] */
            ii(0x1017_1ea6, 3); add(edi, memd_a32[ss, ebp + 0x1c]);     /* add edi, [ebp+0x1c] */
            ii(0x1017_1ea9, 1); dec(edx);                               /* dec edx */
            ii(0x1017_1eaa, 2); if(jnzd(0x1017_1e38, -0x74)) goto l_0x1017_1e38; /* jnz 0x10171e38 */
            ii(0x1017_1eac, 2); if(jzd(0x1017_1ebf, 0x11)) goto l_0x1017_1ebf; /* jz 0x10171ebf */
        l_0x1017_1eae:
            ii(0x1017_1eae, 1); inc(ecx);                               /* inc ecx */
        l_0x1017_1eaf:
            ii(0x1017_1eaf, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_1eb0, 2); if(jzd(0x1017_1ea3, -0xf)) goto l_0x1017_1ea3; /* jz 0x10171ea3 */
            ii(0x1017_1eb2, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1017_1eb4, 1); inc(esi);                               /* inc esi */
            ii(0x1017_1eb5, 1); inc(edi);                               /* inc edi */
            ii(0x1017_1eb6, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1017_1eb8, 2); if(jzd(0x1017_1eaf, -0xb)) goto l_0x1017_1eaf; /* jz 0x10171eaf */
            ii(0x1017_1eba, 3); mov(memb_a32[ds, edi - 0x1], al);       /* mov [edi-0x1], al */
            ii(0x1017_1ebd, 2); jmpd(0x1017_1eaf, -0x10); goto l_0x1017_1eaf; /* jmp 0x10171eaf */
        l_0x1017_1ebf:
            ii(0x1017_1ebf, 1); popd(edi);                              /* pop edi */
            ii(0x1017_1ec0, 1); popd(esi);                              /* pop esi */
            ii(0x1017_1ec1, 1); popd(edx);                              /* pop edx */
            ii(0x1017_1ec2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_1ec3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_1ec4, 1); popd(eax);                              /* pop eax */
            ii(0x1017_1ec5, 1); leaved();                               /* leave */
            ii(0x1017_1ec6, 1); retd(); return;                         /* ret */
        }
    }
}
