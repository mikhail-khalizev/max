using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8923-bd9e8108")]
        public void Method_100e_8923()
        {
            ii(0x100e_8923, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100e_8928, 5); calld(Definitions.sys_check_available_stack_size, 0x7_d425); /* call 0x10165d52 */
            ii(0x100e_892d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_892e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_892f, 1); pushd(edx);                             /* push edx */
            ii(0x100e_8930, 1); pushd(esi);                             /* push esi */
            ii(0x100e_8931, 1); pushd(edi);                             /* push edi */
            ii(0x100e_8932, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_8933, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_8935, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100e_893b, 5); mov(ebx, StringDefinitions.Empty);      /* mov ebx, 0x101a1ef8 */
            ii(0x100e_8940, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_8942, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_8944, 5); calld(/* sys */ 0x1016_e290, 0x8_5947); /* call 0x1016e290 */
            ii(0x100e_8949, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_894b, 5); mov(edx, /* sys */ 0x1017_1880);        /* mov edx, 0x10171880 */
            ii(0x100e_8950, 5); mov(eax, /* sys */ 0x1017_14e0);        /* mov eax, 0x101714e0 */
            ii(0x100e_8955, 5); calld(/* sys */ 0x1016_61f0, 0x7_d896); /* call 0x101661f0 */
            ii(0x100e_895a, 7); mov(memd_a32[ss, ebp - 0x14], 0x101b_7f60); /* mov dword [ebp-0x14], 0x101b7f60 */
            ii(0x100e_8961, 2); pushd(0x2);                             /* push 0x2 */
            ii(0x100e_8963, 2); pushd(0);                               /* push 0x0 */
            ii(0x100e_8965, 5); mov(ecx, 0x1e0);                        /* mov ecx, 0x1e0 */
            ii(0x100e_896a, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x100e_896f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_8971, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_8973, 5); calld(/* sys */ 0x1016_6764, 0x7_ddec); /* call 0x10166764 */
            ii(0x100e_8978, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_897b, 4); cmp(memd_a32[ss, ebp - 0x18], -0x1 /* 0xff */); /* cmp dword [ebp-0x18], 0xffffffff */
            ii(0x100e_897f, 2); if(jnzd(0x100e_8987, 0x6)) goto l_0x100e_8987; /* jnz 0x100e8987 */
            ii(0x100e_8981, 4); mov(memb_a32[ss, ebp - 0x4], 0x3);      /* mov byte [ebp-0x4], 0x3 */
            ii(0x100e_8985, 2); jmpd(0x100e_89b3, 0x2c); goto l_0x100e_89b3; /* jmp 0x100e89b3 */
        l_0x100e_8987:
            ii(0x100e_8987, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_898a, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100e_898d, 3); mov(memd_a32[ds, edx + 0x12], eax);     /* mov [edx+0x12], eax */
            ii(0x100e_8990, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_8993, 5); calld(/* sys */ 0x1016_7dd4, 0x7_f43c); /* call 0x10167dd4 */
            ii(0x100e_8998, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_899a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_899d, 3); mov(memd_a32[ds, eax + 0x16], edx);     /* mov [eax+0x16], edx */
            ii(0x100e_89a0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_89a3, 4); cmp(memd_a32[ds, eax + 0x16], 0);       /* cmp dword [eax+0x16], 0x0 */
            ii(0x100e_89a7, 2); if(jzd(0x100e_89af, 0x6)) goto l_0x100e_89af; /* jz 0x100e89af */
            ii(0x100e_89a9, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x100e_89ad, 2); jmpd(0x100e_89b3, 0x4); goto l_0x100e_89b3; /* jmp 0x100e89b3 */
        l_0x100e_89af:
            ii(0x100e_89af, 4); mov(memb_a32[ss, ebp - 0x4], 0x4);      /* mov byte [ebp-0x4], 0x4 */
        l_0x100e_89b3:
            ii(0x100e_89b3, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_89b7, 2); if(jzd(0x100e_89c1, 0x8)) goto l_0x100e_89c1; /* jz 0x100e89c1 */
            ii(0x100e_89b9, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_89bc, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100e_89bf, 2); jmpd(0x100e_8a34, 0x73); goto l_0x100e_8a34; /* jmp 0x100e8a34 */
        l_0x100e_89c1:
            ii(0x100e_89c1, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_89c4, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x100e_89c7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_89ca, 7); mov(memd_a32[ss, ebp - 0x14], 0x101b_7f60); /* mov dword [ebp-0x14], 0x101b7f60 */
            ii(0x100e_89d1, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100e_89d5, 2); jmpd(0x100e_89e1, 0xa); goto l_0x100e_89e1; /* jmp 0x100e89e1 */
        l_0x100e_89d7:
            ii(0x100e_89d7, 3); inc(memb_a32[ss, ebp - 0x8]);           /* inc byte [ebp-0x8] */
            ii(0x100e_89da, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_89dd, 4); add(memd_a32[ss, ebp - 0x14], 0x1a);    /* add dword [ebp-0x14], 0x1a */
        l_0x100e_89e1:
            ii(0x100e_89e1, 4); cmp(memb_a32[ss, ebp - 0x8], 0x3b);     /* cmp byte [ebp-0x8], 0x3b */
            ii(0x100e_89e5, 2); if(jged(0x100e_8a0e, 0x27)) goto l_0x100e_8a0e; /* jge 0x100e8a0e */
            ii(0x100e_89e7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_89ea, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100e_89ed, 3); mov(memd_a32[ds, edx + 0x12], eax);     /* mov [edx+0x12], eax */
            ii(0x100e_89f0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_89f3, 7); imul(eax, memd_a32[ds, eax + 0x4], 0x280); /* imul eax, [eax+0x4], 0x280 */
            ii(0x100e_89fa, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x100e_89fd, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_89ff, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_8a02, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_8a04, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_8a07, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100e_8a09, 3); mov(memd_a32[ds, eax + 0x16], ebx);     /* mov [eax+0x16], ebx */
            ii(0x100e_8a0c, 2); jmpd(0x100e_89d7, -0x37); goto l_0x100e_89d7; /* jmp 0x100e89d7 */
        l_0x100e_8a0e:
            ii(0x100e_8a0e, 5); mov(eax, 0x300);                        /* mov eax, 0x300 */
            ii(0x100e_8a13, 5); calld(Definitions.sys_malloc, 0x8_25c6); /* call 0x1016afde */
            ii(0x100e_8a18, 5); mov(memd_a32[ds, 0x101c_365c], eax);    /* mov [0x101c365c], eax */
            ii(0x100e_8a1d, 5); mov(ebx, 0x300);                        /* mov ebx, 0x300 */
            ii(0x100e_8a22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_8a24, 5); mov(eax, memd_a32[ds, 0x101c_365c]);    /* mov eax, [0x101c365c] */
            ii(0x100e_8a29, 5); calld(Definitions.sys_memset, 0x7_d3b2); /* call 0x10165de0 */
            ii(0x100e_8a2e, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_8a31, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x100e_8a34:
            ii(0x100e_8a34, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100e_8a37, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8a39, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_8a3a, 1); popd(edi);                              /* pop edi */
            ii(0x100e_8a3b, 1); popd(esi);                              /* pop esi */
            ii(0x100e_8a3c, 1); popd(edx);                              /* pop edx */
            ii(0x100e_8a3d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_8a3e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_8a3f, 1); retd();                                 /* ret */
        }
    }
}
