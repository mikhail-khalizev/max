using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_1cca-566c49ee")]
        public void Method_1007_1cca()
        {
            ii(0x1007_1cca, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_1ccf, 5); calld(Definitions.sys_check_available_stack_size, 0xf_407e); /* call 0x10165d52 */
            ii(0x1007_1cd4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_1cd5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_1cd6, 1); pushd(edx);                             /* push edx */
            ii(0x1007_1cd7, 1); pushd(esi);                             /* push esi */
            ii(0x1007_1cd8, 1); pushd(edi);                             /* push edi */
            ii(0x1007_1cd9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_1cda, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_1cdc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1007_1ce2, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1007_1ce5, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1007_1ce8, 5); mov(memb_a32[ds, 0x101c_3920], al);     /* mov [0x101c3920], al */
            ii(0x1007_1ced, 5); calld(0x1007_0a29, -0x12c9);            /* call 0x10070a29 */
            ii(0x1007_1cf2, 7); cmp(memb_a32[ds, 0x101c_3920], 0);      /* cmp byte [0x101c3920], 0x0 */
            ii(0x1007_1cf9, 2); if(jnzd(0x1007_1d2d, 0x32)) goto l_0x1007_1d2d; /* jnz 0x10071d2d */
            ii(0x1007_1cfb, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1007_1d00, 5); calld(0x1007_1c60, -0xa5);              /* call 0x10071c60 */
            ii(0x1007_1d05, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1007_1d0a, 5); calld(0x1007_1c60, -0xaf);              /* call 0x10071c60 */
            ii(0x1007_1d0f, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1007_1d14, 5); calld(0x1007_1c60, -0xb9);              /* call 0x10071c60 */
            ii(0x1007_1d19, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1007_1d1e, 5); calld(0x1007_1c60, -0xc3);              /* call 0x10071c60 */
            ii(0x1007_1d23, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x1007_1d28, 5); calld(0x1007_1c60, -0xcd);              /* call 0x10071c60 */
        l_0x1007_1d2d:
            ii(0x1007_1d2d, 5); calld(0x1007_6054, 0x4322);             /* call 0x10076054 */
            ii(0x1007_1d32, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_1d34, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_1d36, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_1d38, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1007_1d3b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_1d3e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_1d40, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1007_1d45, 1); cwde();                                 /* cwde */
            ii(0x1007_1d46, 5); calld(0x1007_1d59, 0xe);                /* call 0x10071d59 */
            ii(0x1007_1d4b, 5); calld(0x100f_f5c1, 0x8_d871);           /* call 0x100ff5c1 */
            ii(0x1007_1d50, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_1d52, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_1d53, 1); popd(edi);                              /* pop edi */
            ii(0x1007_1d54, 1); popd(esi);                              /* pop esi */
            ii(0x1007_1d55, 1); popd(edx);                              /* pop edx */
            ii(0x1007_1d56, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_1d57, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_1d58, 1); retd();                                 /* ret */
        }
    }
}
