using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_0f4d-6a40d6d9")]
        public void /* sys */ Method_1018_0f4d()
        {
            ii(0x1018_0f4d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_0f4e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_0f4f, 1); pushd(esi);                             /* push esi */
            ii(0x1018_0f50, 1); pushd(edi);                             /* push edi */
            ii(0x1018_0f51, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_0f52, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_0f54, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_0f56, 4); cmp(memd_a32[ds, edx + 0x8], 0);        /* cmp dword [edx+0x8], 0x0 */
            ii(0x1018_0f5a, 2); if(jnzd(0x1018_0f63, 0x7)) goto l_0x1018_0f63; /* jnz 0x10180f63 */
            ii(0x1018_0f5c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_0f5e, 5); calld(/* sys */ 0x1018_d3ee, 0xc48b);   /* call 0x1018d3ee */
        l_0x1018_0f63:
            ii(0x1018_0f63, 3); mov(ah, memb_a32[ds, ebx + 0xd]);       /* mov ah, [ebx+0xd] */
            ii(0x1018_0f66, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1018_0f68, 3); test(ah, 0x4);                          /* test ah, 0x4 */
            ii(0x1018_0f6b, 2); if(jzd(0x1018_0f7f, 0x12)) goto l_0x1018_0f7f; /* jz 0x10180f7f */
            ii(0x1018_0f6d, 2); mov(dl, ah);                            /* mov dl, ah */
            ii(0x1018_0f6f, 3); and(dl, 0xf9);                          /* and dl, 0xf9 */
            ii(0x1018_0f72, 2); mov(dh, dl);                            /* mov dh, dl */
            ii(0x1018_0f74, 3); or(dh, 0x2);                            /* or dh, 0x2 */
            ii(0x1018_0f77, 5); mov(edi, 0x1);                          /* mov edi, 0x1 */
            ii(0x1018_0f7c, 3); mov(memb_a32[ds, ebx + 0xd], dh);       /* mov [ebx+0xd], dh */
        l_0x1018_0f7f:
            ii(0x1018_0f7f, 2); mov(ebp, ecx);                          /* mov ebp, ecx */
            ii(0x1018_0f81, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1018_0f83:
            ii(0x1018_0f83, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_0f85, 2); mov(al, memb_a32[ds, ecx]);             /* mov al, [ecx] */
            ii(0x1018_0f87, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_0f89, 2); if(jzd(0x1018_0f9a, 0xf)) goto l_0x1018_0f9a; /* jz 0x10180f9a */
            ii(0x1018_0f8b, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1018_0f8d, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_0f8e, 5); calld(/* sys */ 0x1017_29f1, -0xe5a2);  /* call 0x101729f1 */
            ii(0x1018_0f93, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_0f96, 2); if(jnzd(0x1018_0f83, -0x15)) goto l_0x1018_0f83; /* jnz 0x10180f83 */
            ii(0x1018_0f98, 2); mov(esi, eax);                          /* mov esi, eax */
        l_0x1018_0f9a:
            ii(0x1018_0f9a, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_0f9c, 2); if(jzd(0x1018_0fb8, 0x1a)) goto l_0x1018_0fb8; /* jz 0x10180fb8 */
            ii(0x1018_0f9e, 3); mov(al, memb_a32[ds, ebx + 0xd]);       /* mov al, [ebx+0xd] */
            ii(0x1018_0fa1, 2); and(al, 0xf9);                          /* and al, 0xf9 */
            ii(0x1018_0fa3, 2); mov(ah, al);                            /* mov ah, al */
            ii(0x1018_0fa5, 3); or(ah, 0x4);                            /* or ah, 0x4 */
            ii(0x1018_0fa8, 3); mov(memb_a32[ds, ebx + 0xd], ah);       /* mov [ebx+0xd], ah */
            ii(0x1018_0fab, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_0fad, 2); if(jnzd(0x1018_0fb8, 0x9)) goto l_0x1018_0fb8; /* jnz 0x10180fb8 */
            ii(0x1018_0faf, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_0fb1, 5); calld(/* sys */ 0x1018_d5d9, 0xc623);   /* call 0x1018d5d9 */
            ii(0x1018_0fb6, 2); mov(esi, eax);                          /* mov esi, eax */
        l_0x1018_0fb8:
            ii(0x1018_0fb8, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_0fba, 2); if(jnzd(0x1018_0fc0, 0x4)) goto l_0x1018_0fc0; /* jnz 0x10180fc0 */
            ii(0x1018_0fbc, 2); mov(esi, ecx);                          /* mov esi, ecx */
            ii(0x1018_0fbe, 2); sub(esi, ebp);                          /* sub esi, ebp */
        l_0x1018_0fc0:
            ii(0x1018_0fc0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_0fc2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_0fc3, 1); popd(edi);                              /* pop edi */
            ii(0x1018_0fc4, 1); popd(esi);                              /* pop esi */
            ii(0x1018_0fc5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_0fc6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_0fc7, 1); retd();                                 /* ret */
        }
    }
}
