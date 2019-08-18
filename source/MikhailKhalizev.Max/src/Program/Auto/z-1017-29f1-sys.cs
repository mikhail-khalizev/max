using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8d12885b-93fe-4ef0-bc37-bbe2332f7d94")]
        public void /* sys */ Method_1017_29f1()
        {
            ii(0x1017_29f1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_29f2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_29f3, 1); pushd(esi);                             /* push esi */
            ii(0x1017_29f4, 1); pushd(edi);                             /* push edi */
            ii(0x1017_29f5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_29f6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_29f8, 4); test(memb_a32[ds, edx + 0xc], 0x2);     /* test byte [edx+0xc], 0x2 */
            ii(0x1017_29fc, 2); if(jnzd(0x1017_2a16, 0x18)) goto l_0x1017_2a16; /* jnz 0x10172a16 */
            ii(0x1017_29fe, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1017_2a03, 5); calld(/* sys */ 0x1018_d3bf, 0x1_a9b7); /* call 0x1018d3bf */
            ii(0x1017_2a08, 4); or(memb_a32[ds, edx + 0xc], 0x20);      /* or byte [edx+0xc], 0x20 */
        l_0x1017_2a0c:
            ii(0x1017_2a0c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_2a11, 5); jmpd(0x1017_2a8f, 0x79); goto l_0x1017_2a8f; /* jmp 0x10172a8f */
        l_0x1017_2a16:
            ii(0x1017_2a16, 4); cmp(memd_a32[ds, edx + 0x8], 0);        /* cmp dword [edx+0x8], 0x0 */
            ii(0x1017_2a1a, 2); if(jnzd(0x1017_2a23, 0x7)) goto l_0x1017_2a23; /* jnz 0x10172a23 */
            ii(0x1017_2a1c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_2a1e, 5); calld(/* sys */ 0x1018_d3ee, 0x1_a9cb); /* call 0x1018d3ee */
        l_0x1017_2a23:
            ii(0x1017_2a23, 5); mov(ecx, 0x400);                        /* mov ecx, 0x400 */
            ii(0x1017_2a28, 3); cmp(ebx, 0xa);                          /* cmp ebx, 0xa */
            ii(0x1017_2a2b, 2); if(jnzd(0x1017_2a60, 0x33)) goto l_0x1017_2a60; /* jnz 0x10172a60 */
            ii(0x1017_2a2d, 3); mov(al, memb_a32[ds, edx + 0xc]);       /* mov al, [edx+0xc] */
            ii(0x1017_2a30, 5); mov(ecx, 0x600);                        /* mov ecx, 0x600 */
            ii(0x1017_2a35, 2); test(al, 0x40);                         /* test al, 0x40 */
            ii(0x1017_2a37, 2); if(jnzd(0x1017_2a60, 0x27)) goto l_0x1017_2a60; /* jnz 0x10172a60 */
            ii(0x1017_2a39, 4); or(memb_a32[ds, edx + 0xd], 0x10);      /* or byte [edx+0xd], 0x10 */
            ii(0x1017_2a3d, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1017_2a3f, 3); mov(memb_a32[ds, eax], 0xd);            /* mov byte [eax], 0xd */
            ii(0x1017_2a42, 2); mov(esi, memd_a32[ds, edx]);            /* mov esi, [edx] */
            ii(0x1017_2a44, 1); inc(esi);                               /* inc esi */
            ii(0x1017_2a45, 3); mov(edi, memd_a32[ds, edx + 0x4]);      /* mov edi, [edx+0x4] */
            ii(0x1017_2a48, 2); mov(memd_a32[ds, edx], esi);            /* mov [edx], esi */
            ii(0x1017_2a4a, 1); inc(edi);                               /* inc edi */
            ii(0x1017_2a4b, 3); mov(ebp, memd_a32[ds, edx + 0x14]);     /* mov ebp, [edx+0x14] */
            ii(0x1017_2a4e, 3); mov(memd_a32[ds, edx + 0x4], edi);      /* mov [edx+0x4], edi */
            ii(0x1017_2a51, 2); cmp(edi, ebp);                          /* cmp edi, ebp */
            ii(0x1017_2a53, 2); if(jnzd(0x1017_2a60, 0xb)) goto l_0x1017_2a60; /* jnz 0x10172a60 */
            ii(0x1017_2a55, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_2a57, 5); calld(/* sys */ 0x1018_d5d9, 0x1_ab7d); /* call 0x1018d5d9 */
            ii(0x1017_2a5c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_2a5e, 2); if(jnzd(0x1017_2a0c, -0x54)) goto l_0x1017_2a0c; /* jnz 0x10172a0c */
        l_0x1017_2a60:
            ii(0x1017_2a60, 4); or(memb_a32[ds, edx + 0xd], 0x10);      /* or byte [edx+0xd], 0x10 */
            ii(0x1017_2a64, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1017_2a66, 2); mov(memb_a32[ds, eax], bl);             /* mov [eax], bl */
            ii(0x1017_2a68, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1017_2a6a, 1); inc(eax);                               /* inc eax */
            ii(0x1017_2a6b, 3); mov(esi, memd_a32[ds, edx + 0x4]);      /* mov esi, [edx+0x4] */
            ii(0x1017_2a6e, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1017_2a70, 1); inc(esi);                               /* inc esi */
            ii(0x1017_2a71, 3); mov(edi, memd_a32[ds, edx + 0xc]);      /* mov edi, [edx+0xc] */
            ii(0x1017_2a74, 3); mov(memd_a32[ds, edx + 0x4], esi);      /* mov [edx+0x4], esi */
            ii(0x1017_2a77, 2); test(ecx, edi);                         /* test ecx, edi */
            ii(0x1017_2a79, 2); if(jnzd(0x1017_2a80, 0x5)) goto l_0x1017_2a80; /* jnz 0x10172a80 */
            ii(0x1017_2a7b, 3); cmp(esi, memd_a32[ds, edx + 0x14]);     /* cmp esi, [edx+0x14] */
            ii(0x1017_2a7e, 2); if(jnzd(0x1017_2a8b, 0xb)) goto l_0x1017_2a8b; /* jnz 0x10172a8b */
        l_0x1017_2a80:
            ii(0x1017_2a80, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_2a82, 5); calld(/* sys */ 0x1018_d5d9, 0x1_ab52); /* call 0x1018d5d9 */
            ii(0x1017_2a87, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_2a89, 2); if(jnzd(0x1017_2a0c, -0x7f)) goto l_0x1017_2a0c; /* jnz 0x10172a0c */
        l_0x1017_2a8b:
            ii(0x1017_2a8b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_2a8d, 2); mov(al, bl);                            /* mov al, bl */
        l_0x1017_2a8f:
            ii(0x1017_2a8f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_2a90, 1); popd(edi);                              /* pop edi */
            ii(0x1017_2a91, 1); popd(esi);                              /* pop esi */
            ii(0x1017_2a92, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_2a93, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_2a94, 1); retd(); return;                         /* ret */
        }
    }
}
