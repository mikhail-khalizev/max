using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1449-c0d0d932")]
        public void Method_1014_1449()
        {
            ii(0x1014_1449, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_144e, 5); calld(Definitions.sys_check_available_stack_size, 0x2_48ff); /* call 0x10165d52 */
            ii(0x1014_1453, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1454, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1455, 1); pushd(edx);                             /* push edx */
            ii(0x1014_1456, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1457, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1458, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1459, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_145b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_1461, 6); mov(edx, memd_a32[ds, 0x101c_810e]);    /* mov edx, [0x101c810e] */
            ii(0x1014_1467, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_146a, 1); inc(edx);                               /* inc edx */
            ii(0x1014_146b, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1014_1470, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_1472, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_1475, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1014_1477, 7); mov(memw_a32[ds, 0x101c_8110], dx);     /* mov [0x101c8110], dx */
            ii(0x1014_147e, 6); mov(ax, memw_a32[ds, 0x101c_8110]);     /* mov ax, [0x101c8110] */
            ii(0x1014_1484, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_1487, 2); jmpd(0x1014_14f4, 0x6b); goto l_0x1014_14f4; /* jmp 0x101414f4 */
        l_0x1014_1489:
            ii(0x1014_1489, 5); calld(0x100c_aa00, -0x7_6a8e);          /* call 0x100caa00 */
            ii(0x1014_148e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_1493, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1494, 5); calld(0x100c_aa20, -0x7_6a79);          /* call 0x100caa20 */
            ii(0x1014_1499, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1014_149b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_149d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_149f, 5); mov(eax, StringDefinitions.TaskDebugInfoOn); /* mov eax, 0x101ace61 */
            ii(0x1014_14a4, 5); calld(0x1011_5d23, -0x2_b786);          /* call 0x10115d23 */
            ii(0x1014_14a9, 5); jmpd(0x1014_151a, 0x6c); goto l_0x1014_151a; /* jmp 0x1014151a */
        l_0x1014_14ae:
            ii(0x1014_14ae, 5); calld(0x100c_aa00, -0x7_6ab3);          /* call 0x100caa00 */
            ii(0x1014_14b3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_14b8, 1); pushd(eax);                             /* push eax */
            ii(0x1014_14b9, 5); calld(0x100c_aa20, -0x7_6a9e);          /* call 0x100caa20 */
            ii(0x1014_14be, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1014_14c0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_14c2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_14c4, 5); mov(eax, StringDefinitions.TaskDebugInfoOff); /* mov eax, 0x101ace74 */
            ii(0x1014_14c9, 5); calld(0x1011_5d23, -0x2_b7ab);          /* call 0x10115d23 */
            ii(0x1014_14ce, 2); jmpd(0x1014_151a, 0x4a); goto l_0x1014_151a; /* jmp 0x1014151a */
        l_0x1014_14d0:
            ii(0x1014_14d0, 5); calld(0x100c_aa00, -0x7_6ad5);          /* call 0x100caa00 */
            ii(0x1014_14d5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_14da, 1); pushd(eax);                             /* push eax */
            ii(0x1014_14db, 5); calld(0x100c_aa20, -0x7_6ac0);          /* call 0x100caa20 */
            ii(0x1014_14e0, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1014_14e2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_14e4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_14e6, 5); mov(eax, StringDefinitions.TaskLogOn);  /* mov eax, 0x101ace88 */
            ii(0x1014_14eb, 5); calld(0x1011_5d23, -0x2_b7cd);          /* call 0x10115d23 */
            ii(0x1014_14f0, 2); jmpd(0x1014_151a, 0x28); goto l_0x1014_151a; /* jmp 0x1014151a */
        l_0x1014_14f2:
            ii(0x1014_14f2, 2); jmpd(0x1014_151a, 0x26); goto l_0x1014_151a; /* jmp 0x1014151a */
        l_0x1014_14f4:
            ii(0x1014_14f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_14f7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_14fa, 5); cmp(memw_a32[ss, ebp - 0x8], 0x1);      /* cmp word [ebp-0x8], 0x1 */
            ii(0x1014_14ff, 2); if(jbd(0x1014_1511, 0x10)) goto l_0x1014_1511; /* jb 0x10141511 */
            ii(0x1014_1501, 5); cmp(memw_a32[ss, ebp - 0x8], 0x1);      /* cmp word [ebp-0x8], 0x1 */
            ii(0x1014_1506, 2); if(jbed(0x1014_1489, -0x7f)) goto l_0x1014_1489; /* jbe 0x10141489 */
            ii(0x1014_1508, 5); cmp(memw_a32[ss, ebp - 0x8], 0x2);      /* cmp word [ebp-0x8], 0x2 */
            ii(0x1014_150d, 2); if(jzd(0x1014_14d0, -0x3f)) goto l_0x1014_14d0; /* jz 0x101414d0 */
            ii(0x1014_150f, 2); jmpd(0x1014_14f2, -0x1f); goto l_0x1014_14f2; /* jmp 0x101414f2 */
        l_0x1014_1511:
            ii(0x1014_1511, 5); cmp(memw_a32[ss, ebp - 0x8], 0);        /* cmp word [ebp-0x8], 0x0 */
            ii(0x1014_1516, 2); if(jzd(0x1014_14ae, -0x6a)) goto l_0x1014_14ae; /* jz 0x101414ae */
            ii(0x1014_1518, 2); jmpd(0x1014_14f2, -0x28); goto l_0x1014_14f2; /* jmp 0x101414f2 */
        l_0x1014_151a:
            ii(0x1014_151a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_151c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_151d, 1); popd(edi);                              /* pop edi */
            ii(0x1014_151e, 1); popd(esi);                              /* pop esi */
            ii(0x1014_151f, 1); popd(edx);                              /* pop edx */
            ii(0x1014_1520, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1521, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1522, 1); retd(); return;                         /* ret */
        }
    }
}
