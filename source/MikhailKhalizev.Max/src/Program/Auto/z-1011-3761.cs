using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_3761-85e1df72")]
        public void Method_1011_3761()
        {
            ii(0x1011_3761, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_3766, 5); calld(Definitions.sys_check_available_stack_size, 0x5_25e7); /* call 0x10165d52 */
            ii(0x1011_376b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_376c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_376d, 1); pushd(edx);                             /* push edx */
            ii(0x1011_376e, 1); pushd(esi);                             /* push esi */
            ii(0x1011_376f, 1); pushd(edi);                             /* push edi */
            ii(0x1011_3770, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_3771, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_3773, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_3779, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_377c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_3781, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
            ii(0x1011_3786, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3789, 5); calld(0x1011_285d, -0xf31);             /* call 0x1011285d */
            ii(0x1011_378e, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_3793, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1011_3798, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_379b, 5); calld(0x1011_285d, -0xf43);             /* call 0x1011285d */
            ii(0x1011_37a0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_37a3, 4); cmp(memb_a32[ds, eax + 0x8], 0);        /* cmp byte [eax+0x8], 0x0 */
            ii(0x1011_37a7, 2); if(jzd(0x1011_37c4, 0x1b)) goto l_0x1011_37c4; /* jz 0x101137c4 */
            ii(0x1011_37a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_37ac, 5); calld(0x1011_36c0, -0xf1);              /* call 0x101136c0 */
            ii(0x1011_37b1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_37b3, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_37b5, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1011_37ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_37bd, 5); calld(0x1011_285d, -0xf65);             /* call 0x1011285d */
            ii(0x1011_37c2, 2); jmpd(0x1011_37f0, 0x2c); goto l_0x1011_37f0; /* jmp 0x101137f0 */
        l_0x1011_37c4:
            ii(0x1011_37c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_37c7, 3); mov(al, memb_a32[ds, eax + 0xb]);       /* mov al, [eax+0xb] */
            ii(0x1011_37ca, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_37cf, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_37d2, 2); if(jnzd(0x1011_37da, 0x6)) goto l_0x1011_37da; /* jnz 0x101137da */
            ii(0x1011_37d4, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1011_37d8, 2); jmpd(0x1011_37de, 0x4); goto l_0x1011_37de; /* jmp 0x101137de */
        l_0x1011_37da:
            ii(0x1011_37da, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1011_37de:
            ii(0x1011_37de, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_37e0, 3); mov(bl, memb_a32[ss, ebp - 0x8]);       /* mov bl, [ebp-0x8] */
            ii(0x1011_37e3, 5); mov(edx, 0x16);                         /* mov edx, 0x16 */
            ii(0x1011_37e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_37eb, 5); calld(0x1011_285d, -0xf93);             /* call 0x1011285d */
        l_0x1011_37f0:
            ii(0x1011_37f0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_37f2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_37f3, 1); popd(edi);                              /* pop edi */
            ii(0x1011_37f4, 1); popd(esi);                              /* pop esi */
            ii(0x1011_37f5, 1); popd(edx);                              /* pop edx */
            ii(0x1011_37f6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_37f7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_37f8, 1); retd();                                 /* ret */
        }
    }
}
