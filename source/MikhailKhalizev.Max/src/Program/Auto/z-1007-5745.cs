using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3a1d4048-0f42-449d-b25d-3e5032fa4fdc")]
        public void Method_1007_5745()
        {
            ii(0x1007_5745, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_574a, 5); calld(Definitions.sys_check_available_stack_size, 0xf0603); /* call 0x10165d52 */
            ii(0x1007_574f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_5750, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_5751, 1); pushd(edx);                             /* push edx */
            ii(0x1007_5752, 1); pushd(esi);                             /* push esi */
            ii(0x1007_5753, 1); pushd(edi);                             /* push edi */
            ii(0x1007_5754, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_5755, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5757, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1007_575d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_5760, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_5763, 5); calld(0x1011_9138, 0xa39d0);            /* call 0x10119138 */
            ii(0x1007_5768, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1007_576b, 3); add(ebx, 0x65);                         /* add ebx, 0x65 */
            ii(0x1007_576e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_5770, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_5772, 5); calld(0x1007_6a34, 0x12bd);             /* call 0x10076a34 */
            ii(0x1007_5777, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5779, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_577c, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1007_577f, 5); calld(0x1013_ad11, 0xc558d);            /* call 0x1013ad11 */
            ii(0x1007_5784, 2); test(al, al);                           /* test al, al */
            ii(0x1007_5786, 2); if(jzd(0x1007_57ad, 0x25)) goto l_0x1007_57ad; /* jz 0x100757ad */
            ii(0x1007_5788, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_578a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_578d, 5); calld(0x1014_f017, 0xd9885);            /* call 0x1014f017 */
            ii(0x1007_5792, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1007_5799, 2); if(jzd(0x1007_57a3, 0x8)) goto l_0x1007_57a3; /* jz 0x100757a3 */
            ii(0x1007_579b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_579e, 5); calld(0x1012_b020, 0xb587d);            /* call 0x1012b020 */
        l_0x1007_57a3:
            ii(0x1007_57a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_57a6, 5); calld(0x1014_b6bd, 0xd5f12);            /* call 0x1014b6bd */
            ii(0x1007_57ab, 2); jmpd(0x1007_57be, 0x11); goto l_0x1007_57be; /* jmp 0x100757be */
        l_0x1007_57ad:
            ii(0x1007_57ad, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1007_57b4, 2); if(jzd(0x1007_57be, 0x8)) goto l_0x1007_57be; /* jz 0x100757be */
            ii(0x1007_57b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_57b9, 5); calld(0x1012_ae8d, 0xb56cf);            /* call 0x1012ae8d */
        l_0x1007_57be:
            ii(0x1007_57be, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_57c0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_57c1, 1); popd(edi);                              /* pop edi */
            ii(0x1007_57c2, 1); popd(esi);                              /* pop esi */
            ii(0x1007_57c3, 1); popd(edx);                              /* pop edx */
            ii(0x1007_57c4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_57c5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_57c6, 1); retd(); return;                         /* ret */
        }
    }
}
