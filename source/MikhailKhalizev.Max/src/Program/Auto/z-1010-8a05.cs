using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5df41fa5-6db2-4c01-9686-8a08939b27a0")]
        public void Method_1010_8a05()
        {
            ii(0x1010_8a05, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1010_8a0a, 5); calld(Definitions.sys_check_available_stack_size, 0x5_d343); /* call 0x10165d52 */
            ii(0x1010_8a0f, 1); pushd(esi);                             /* push esi */
            ii(0x1010_8a10, 1); pushd(edi);                             /* push edi */
            ii(0x1010_8a11, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_8a12, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8a14, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_8a1a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_8a1d, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_8a20, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1010_8a23, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1010_8a26, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_8a29, 4); cmp(memd_a32[ds, eax + 0x10], 0);       /* cmp dword [eax+0x10], 0x0 */
            ii(0x1010_8a2d, 2); if(jzd(0x1010_8a3e, 0xf)) goto l_0x1010_8a3e; /* jz 0x10108a3e */
            ii(0x1010_8a2f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_8a32, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1010_8a35, 5); calld(Definitions.sys_strlen, 0x6_948d); /* call 0x10171ec7 */
            ii(0x1010_8a3a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8a3c, 2); if(jnzd(0x1010_8a40, 0x2)) goto l_0x1010_8a40; /* jnz 0x10108a40 */
        l_0x1010_8a3e:
            ii(0x1010_8a3e, 2); jmpd(0x1010_8a99, 0x59); goto l_0x1010_8a99; /* jmp 0x10108a99 */
        l_0x1010_8a40:
            ii(0x1010_8a40, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_8a42, 3); mov(al, memb_a32[ss, ebp + 0x10]);      /* mov al, [ebp+0x10] */
            ii(0x1010_8a45, 1); pushd(eax);                             /* push eax */
            ii(0x1010_8a46, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_8a48, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1010_8a4b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_8a4c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_8a4f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_8a50, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_8a53, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1010_8a57, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_8a5a, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x1010_8a5e, 1); cwde();                                 /* cwde */
            ii(0x1010_8a5f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_8a60, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_8a63, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1010_8a67, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_8a6a, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1010_8a6d, 1); cwde();                                 /* cwde */
            ii(0x1010_8a6e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_8a6f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_8a72, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1010_8a75, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_8a78, 1); pushd(eax);                             /* push eax */
            ii(0x1010_8a79, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_8a7c, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1010_8a7f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_8a82, 3); mov(ebx, memd_a32[ds, eax + 0x10]);     /* mov ebx, [eax+0x10] */
            ii(0x1010_8a85, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_8a88, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1010_8a8b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_8a8e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_8a91, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1010_8a94, 5); calld(0x100e_9ae5, -0x1_efb4);          /* call 0x100e9ae5 */
        l_0x1010_8a99:
            ii(0x1010_8a99, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_8a9b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_8a9c, 1); popd(edi);                              /* pop edi */
            ii(0x1010_8a9d, 1); popd(esi);                              /* pop esi */
            ii(0x1010_8a9e, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
