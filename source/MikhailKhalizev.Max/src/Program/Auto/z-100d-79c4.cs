using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e7cdd5a8-3731-48f3-b238-76228fc883d6")]
        public void Method_100d_79c4()
        {
            ii(0x100d_79c4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_79c9, 5); calld(Definitions.sys_check_available_stack_size, 0x8_e384); /* call 0x10165d52 */
            ii(0x100d_79ce, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_79cf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_79d0, 1); pushd(esi);                             /* push esi */
            ii(0x100d_79d1, 1); pushd(edi);                             /* push edi */
            ii(0x100d_79d2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_79d3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_79d5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_79db, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_79de, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_79e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_79e4, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100d_79e7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_79e9, 2); if(jged(0x100d_7a2f, 0x44)) goto l_0x100d_7a2f; /* jge 0x100d7a2f */
            ii(0x100d_79eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_79ee, 3); mov(edx, memd_a32[ds, eax + 0x50]);     /* mov edx, [eax+0x50] */
            ii(0x100d_79f1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_79f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_79f7, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100d_79fa, 2); neg(eax);                               /* neg eax */
            ii(0x100d_79fc, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100d_79fe, 2); if(jled(0x100d_7a18, 0x18)) goto l_0x100d_7a18; /* jle 0x100d7a18 */
            ii(0x100d_7a00, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7a03, 4); mov(dx, memw_a32[ds, eax + 0x52]);      /* mov dx, [eax+0x52] */
            ii(0x100d_7a07, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7a0a, 3); add(memw_a32[ds, eax], dx);             /* add [eax], dx */
            ii(0x100d_7a0d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7a10, 6); mov(memw_a32[ds, eax + 0x52], 0);       /* mov word [eax+0x52], 0x0 */
            ii(0x100d_7a16, 2); jmpd(0x100d_7a2d, 0x15); goto l_0x100d_7a2d; /* jmp 0x100d7a2d */
        l_0x100d_7a18:
            ii(0x100d_7a18, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7a1b, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x100d_7a1e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7a21, 4); add(memw_a32[ds, eax + 0x52], dx);      /* add [eax+0x52], dx */
            ii(0x100d_7a25, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7a28, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
        l_0x100d_7a2d:
            ii(0x100d_7a2d, 2); jmpd(0x100d_7a7b, 0x4c); goto l_0x100d_7a7b; /* jmp 0x100d7a7b */
        l_0x100d_7a2f:
            ii(0x100d_7a2f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7a32, 5); calld(0x1007_623c, -0x6_17fb);          /* call 0x1007623c */
            ii(0x100d_7a37, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x100d_7a3b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_7a3e, 4); sub(ax, memw_a32[ds, edx + 0x52]);      /* sub ax, [edx+0x52] */
            ii(0x100d_7a42, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_7a45, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7a48, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100d_7a4b, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_7a4f, 2); if(jled(0x100d_7a66, 0x15)) goto l_0x100d_7a66; /* jle 0x100d7a66 */
            ii(0x100d_7a51, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_7a54, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_7a57, 3); sub(memw_a32[ds, edx], ax);             /* sub [edx], ax */
            ii(0x100d_7a5a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_7a5d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_7a60, 4); add(memw_a32[ds, edx + 0x52], ax);      /* add [edx+0x52], ax */
            ii(0x100d_7a64, 2); jmpd(0x100d_7a7b, 0x15); goto l_0x100d_7a7b; /* jmp 0x100d7a7b */
        l_0x100d_7a66:
            ii(0x100d_7a66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7a69, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x100d_7a6c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7a6f, 4); add(memw_a32[ds, eax + 0x52], dx);      /* add [eax+0x52], dx */
            ii(0x100d_7a73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7a76, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
        l_0x100d_7a7b:
            ii(0x100d_7a7b, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x100d_7a80, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7a83, 5); calld(0x1007_6d98, -0x6_0cf0);          /* call 0x10076d98 */
            ii(0x100d_7a88, 2); test(al, al);                           /* test al, al */
            ii(0x100d_7a8a, 2); if(jzd(0x100d_7a94, 0x8)) goto l_0x100d_7a94; /* jz 0x100d7a94 */
            ii(0x100d_7a8c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7a8f, 5); calld(0x1010_094d, 0x2_8eb9);           /* call 0x1010094d */
        l_0x100d_7a94:
            ii(0x100d_7a94, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7a96, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_7a97, 1); popd(edi);                              /* pop edi */
            ii(0x100d_7a98, 1); popd(esi);                              /* pop esi */
            ii(0x100d_7a99, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_7a9a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_7a9b, 1); retd(); return;                         /* ret */
        }
    }
}
