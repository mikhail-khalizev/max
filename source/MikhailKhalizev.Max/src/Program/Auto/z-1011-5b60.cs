using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("69793bbf-688a-4f96-91c9-14c95e625289")]
        public void Method_1011_5b60()
        {
            ii(0x1011_5b60, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1011_5b65, 5); calld(Definitions.sys_check_available_stack_size, 0x501e8); /* call 0x10165d52 */
            ii(0x1011_5b6a, 1); pushd(esi);                             /* push esi */
            ii(0x1011_5b6b, 1); pushd(edi);                             /* push edi */
            ii(0x1011_5b6c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_5b6d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5b6f, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1011_5b75, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_5b78, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_5b7b, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_5b7e, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1011_5b81, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_5b84, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1011_5b86, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_5b8b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_5b8d, 6); if(jzd(0x1011_5c59, 0xc6)) goto l_0x1011_5c59; /* jz 0x10115c59 */
            ii(0x1011_5b93, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1011_5b98, 5); calld(Definitions.sys_new, 0x50263);    /* call 0x10165e00 */
            ii(0x1011_5b9d, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_5ba0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_5ba3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_5ba6, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1011_5baa, 2); if(jzd(0x1011_5bd2, 0x26)) goto l_0x1011_5bd2; /* jz 0x10115bd2 */
            ii(0x1011_5bac, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x1011_5baf, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_5bb2, 5); calld(0x1007_5e64, -0x9fd53);           /* call 0x10075e64 */
            ii(0x1011_5bb7, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_5bb9, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_5bbc, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_5bbf, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_5bc2, 5); calld(0x1011_76c8, 0x1b01);             /* call 0x101176c8 */
            ii(0x1011_5bc7, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_5bca, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1011_5bcd, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1011_5bd0, 2); jmpd(0x1011_5bd8, 0x6); goto l_0x1011_5bd8; /* jmp 0x10115bd8 */
        l_0x1011_5bd2:
            ii(0x1011_5bd2, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_5bd5, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x1011_5bd8:
            ii(0x1011_5bd8, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1011_5bdb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5bdd, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_5be2, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_5be5, 5); mov(ebx, 0x101c_52bc);                  /* mov ebx, 0x101c52bc */
            ii(0x1011_5bea, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_5bec, 5); calld(0x1011_7c3c, 0x204b);             /* call 0x10117c3c */
            ii(0x1011_5bf1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5bf3, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_5bf8, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1011_5bfb, 5); mov(eax, 0x101c_52bc);                  /* mov eax, 0x101c52bc */
            ii(0x1011_5c00, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_5c02, 5); calld(0x1007_6b90, -0x9f077);           /* call 0x10076b90 */
            ii(0x1011_5c07, 1); cwde();                                 /* cwde */
            ii(0x1011_5c08, 3); cmp(eax, 0x32);                         /* cmp eax, 0x32 */
            ii(0x1011_5c0b, 2); if(jled(0x1011_5c3e, 0x31)) goto l_0x1011_5c3e; /* jle 0x10115c3e */
            ii(0x1011_5c0d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5c0f, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_5c14, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_5c17, 5); mov(ebx, 0x101c_52bc);                  /* mov ebx, 0x101c52bc */
            ii(0x1011_5c1c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_5c1e, 5); calld(0x1011_7c6c, 0x2049);             /* call 0x10117c6c */
            ii(0x1011_5c23, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_5c25, 6); mov(bl, memb_a32[ds, 0x101c_37da]);     /* mov bl, [0x101c37da] */
            ii(0x1011_5c2b, 3); imul(edx, ebx, 0xa);                    /* imul edx, ebx, 0xa */
            ii(0x1011_5c2e, 5); mov(ebx, 0x101c_52bc);                  /* mov ebx, 0x101c52bc */
            ii(0x1011_5c33, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1011_5c35, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_5c37, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_5c39, 5); calld(0x1011_7c0c, 0x1fce);             /* call 0x10117c0c */
        l_0x1011_5c3e:
            ii(0x1011_5c3e, 5); calld(0x100c_aa00, -0x4b243);           /* call 0x100caa00 */
            ii(0x1011_5c43, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_5c48, 1); pushd(eax);                             /* push eax */
            ii(0x1011_5c49, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_5c4b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_5c4d, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x1011_5c51, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_5c54, 5); calld(0x1011_5d23, 0xca);               /* call 0x10115d23 */
        l_0x1011_5c59:
            ii(0x1011_5c59, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_5c5b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5c5c, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5c5d, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5c5e, 1); retd(); return;                         /* ret */
        }
    }
}