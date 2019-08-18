using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("855e1e37-a509-4440-ba51-86ae06d49031")]
        public void Method_1007_b0f1()
        {
            ii(0x1007_b0f1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_b0f6, 5); calld(Definitions.sys_check_available_stack_size, 0xe_ac57); /* call 0x10165d52 */
            ii(0x1007_b0fb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_b0fc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_b0fd, 1); pushd(edx);                             /* push edx */
            ii(0x1007_b0fe, 1); pushd(esi);                             /* push esi */
            ii(0x1007_b0ff, 1); pushd(edi);                             /* push edi */
            ii(0x1007_b100, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_b101, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_b103, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_b109, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_b10c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_b10e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b111, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b114, 5); calld(0x1013_ad11, 0xb_fbf8);           /* call 0x1013ad11 */
            ii(0x1007_b119, 2); test(al, al);                           /* test al, al */
            ii(0x1007_b11b, 2); if(jzd(0x1007_b12e, 0x11)) goto l_0x1007_b12e; /* jz 0x1007b12e */
            ii(0x1007_b11d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b120, 4); mov(ax, memw_a32[ds, eax + 0xd]);       /* mov ax, [eax+0xd] */
            ii(0x1007_b124, 5); add(eax, 0xff);                         /* add eax, 0xff */
            ii(0x1007_b129, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_b12c, 2); jmpd(0x1007_b160, 0x32); goto l_0x1007_b160; /* jmp 0x1007b160 */
        l_0x1007_b12e:
            ii(0x1007_b12e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b131, 3); mov(ebx, memd_a32[ds, eax + 0x7]);      /* mov ebx, [eax+0x7] */
            ii(0x1007_b134, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_b137, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b13a, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b13d, 5); calld(0x1008_a228, 0xf0e6);             /* call 0x1008a228 */
            ii(0x1007_b142, 5); calld(0x1008_a370, 0xf229);             /* call 0x1008a370 */
            ii(0x1007_b147, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_b149, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_b14b, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1007_b14d, 5); calld(0x1007_cfc2, 0x1e70);             /* call 0x1007cfc2 */
            ii(0x1007_b152, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_b154, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b157, 4); mov(ax, memw_a32[ds, eax + 0xd]);       /* mov ax, [eax+0xd] */
            ii(0x1007_b15b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1007_b15d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1007_b160:
            ii(0x1007_b160, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b163, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_b165, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_b166, 1); popd(edi);                              /* pop edi */
            ii(0x1007_b167, 1); popd(esi);                              /* pop esi */
            ii(0x1007_b168, 1); popd(edx);                              /* pop edx */
            ii(0x1007_b169, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_b16a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_b16b, 1); retd(); return;                         /* ret */
        }
    }
}
