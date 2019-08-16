using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b83c21c0-6da9-43c8-9441-0a8781284459")]
        public void Method_1009_0b73()
        {
            ii(0x1009_0b73, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1009_0b78, 5); calld(Definitions.sys_check_available_stack_size, 0xd_51d5); /* call 0x10165d52 */
            ii(0x1009_0b7d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_0b7e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_0b7f, 1); pushd(edx);                             /* push edx */
            ii(0x1009_0b80, 1); pushd(esi);                             /* push esi */
            ii(0x1009_0b81, 1); pushd(edi);                             /* push edi */
            ii(0x1009_0b82, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_0b83, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_0b85, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_0b8b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_0b8e, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_0b93, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_0b96, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_0b99, 5); calld(Definitions.sys_new_arr, 0xd_5472); /* call 0x10166010 */
            ii(0x1009_0b9e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_0ba1, 6); mov(ax, memw_a32[ds, 0x101c_8172]);     /* mov ax, [0x101c8172] */
            ii(0x1009_0ba7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_0baa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0bad, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1009_0bb0:
            ii(0x1009_0bb0, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1009_0bb3, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1009_0bb8, 2); if(jzd(0x1009_0bd4, 0x1a)) goto l_0x1009_0bd4; /* jz 0x10090bd4 */
            ii(0x1009_0bba, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1009_0bbf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_0bc2, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_0bc4, 5); calld(Definitions.sys_new_arr, 0xd_5447); /* call 0x10166010 */
            ii(0x1009_0bc9, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_0bcc, 4); add(memd_a32[ss, ebp - 0xc], 0x4);      /* add dword [ebp-0xc], 0x4 */
            ii(0x1009_0bd0, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1009_0bd2, 2); jmpd(0x1009_0bb0, -0x24); goto l_0x1009_0bb0; /* jmp 0x10090bb0 */
        l_0x1009_0bd4:
            ii(0x1009_0bd4, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1009_0bd9, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0bda, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1009_0bdf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_0be2, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0be3, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_0be8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_0beb, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0bec, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1009_0bee, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_0bf0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1009_0bf3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_0bf6, 5); calld(0x1009_0aaa, -0x151);             /* call 0x10090aaa */
            ii(0x1009_0bfb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0bfe, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_0c01, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_0c04, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_0c06, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_0c07, 1); popd(edi);                              /* pop edi */
            ii(0x1009_0c08, 1); popd(esi);                              /* pop esi */
            ii(0x1009_0c09, 1); popd(edx);                              /* pop edx */
            ii(0x1009_0c0a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_0c0b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_0c0c, 1); retd(); return;                         /* ret */
        }
    }
}