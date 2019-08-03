using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e114080f-9a4a-459d-a3be-62344f68a52b")]
        public void Method_100d_9e3f()
        {
            ii(0x100d_9e3f, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100d_9e44, 5); calld(Definitions.sys_check_available_stack_size, 0x8bf09); /* call 0x10165d52 */
            ii(0x100d_9e49, 1); pushd(esi);                             /* push esi */
            ii(0x100d_9e4a, 1); pushd(edi);                             /* push edi */
            ii(0x100d_9e4b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_9e4c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_9e4e, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100d_9e54, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_9e57, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100d_9e5a, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x100d_9e5d, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100d_9e60, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x100d_9e65, 5); calld(Definitions.sys_new, 0x8bf96);    /* call 0x10165e00 */
            ii(0x100d_9e6a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_9e6d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_9e70, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_9e73, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100d_9e77, 2); if(jzd(0x100d_9ed2, 0x59)) goto l_0x100d_9ed2; /* jz 0x100d9ed2 */
            ii(0x100d_9e79, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_9e7c, 3); add(eax, 0x4f);                         /* add eax, 0x4f */
            ii(0x100d_9e7f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_9e80, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_9e83, 4); mov(ax, memw_a32[ds, eax + 0x51]);      /* mov ax, [eax+0x51] */
            ii(0x100d_9e87, 5); add(eax, 0x401);                        /* add eax, 0x401 */
            ii(0x100d_9e8c, 1); cwde();                                 /* cwde */
            ii(0x100d_9e8d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_9e8e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_9e91, 4); mov(ax, memw_a32[ds, eax + 0x51]);      /* mov ax, [eax+0x51] */
            ii(0x100d_9e95, 5); add(eax, 0x3f7);                        /* add eax, 0x3f7 */
            ii(0x100d_9e9a, 1); cwde();                                 /* cwde */
            ii(0x100d_9e9b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_9e9c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_9e9f, 3); mov(ecx, memd_a32[ds, eax + 0x51]);     /* mov ecx, [eax+0x51] */
            ii(0x100d_9ea2, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_9ea5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_9ea8, 6); mov(eax, memd_a32[ds, eax + 0x3a3]);    /* mov eax, [eax+0x3a3] */
            ii(0x100d_9eae, 5); calld(0x100d_4ef0, -0x4fc3);            /* call 0x100d4ef0 */
            ii(0x100d_9eb3, 3); sub(eax, 0x26);                         /* sub eax, 0x26 */
            ii(0x100d_9eb6, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_9eb9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_9ebc, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_9ebf, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_9ec2, 5); calld(0x100d_82fd, -0x1bca);            /* call 0x100d82fd */
            ii(0x100d_9ec7, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_9eca, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_9ecd, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_9ed0, 2); jmpd(0x100d_9ed8, 0x6); goto l_0x100d_9ed8; /* jmp 0x100d9ed8 */
        l_0x100d_9ed2:
            ii(0x100d_9ed2, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_9ed5, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100d_9ed8:
            ii(0x100d_9ed8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_9edb, 3); mov(eax, memd_a32[ds, eax + 0x4f]);     /* mov eax, [eax+0x4f] */
            ii(0x100d_9ede, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_9ee1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_9ee4, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x100d_9ee7, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100d_9ee9, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_9eec, 6); mov(memd_a32[ds, ebx + 0x375], eax);    /* mov [ebx+0x375], eax */
            ii(0x100d_9ef2, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x100d_9ef6, 1); pushd(eax);                             /* push eax */
            ii(0x100d_9ef7, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x100d_9efa, 1); pushd(eax);                             /* push eax */
            ii(0x100d_9efb, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x100d_9eff, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x100d_9f03, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100d_9f07, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_9f0a, 3); mov(eax, memd_a32[ds, eax + 0x4f]);     /* mov eax, [eax+0x4f] */
            ii(0x100d_9f0d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_9f10, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_9f13, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100d_9f16, 6); mov(eax, memd_a32[ds, eax + 0x375]);    /* mov eax, [eax+0x375] */
            ii(0x100d_9f1c, 5); calld(0x100d_8903, -0x161e);            /* call 0x100d8903 */
            ii(0x100d_9f21, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_9f24, 4); inc(memw_a32[ds, eax + 0x51]);          /* inc word [eax+0x51] */
            ii(0x100d_9f28, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_9f2b, 5); add(memw_a32[ds, eax + 0x53], 0x13);    /* add word [eax+0x53], 0x13 */
            ii(0x100d_9f30, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_9f32, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_9f33, 1); popd(edi);                              /* pop edi */
            ii(0x100d_9f34, 1); popd(esi);                              /* pop esi */
            ii(0x100d_9f35, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}
