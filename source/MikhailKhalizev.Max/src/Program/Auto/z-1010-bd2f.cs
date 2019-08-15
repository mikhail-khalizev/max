using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a1b7f7d3-4c11-40ae-8504-8a4d7ec03c23")]
        public void Method_1010_bd2f()
        {
            ii(0x1010_bd2f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_bd34, 5); calld(Definitions.sys_check_available_stack_size, 0x5_a019); /* call 0x10165d52 */
            ii(0x1010_bd39, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_bd3a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_bd3b, 1); pushd(edx);                             /* push edx */
            ii(0x1010_bd3c, 1); pushd(esi);                             /* push esi */
            ii(0x1010_bd3d, 1); pushd(edi);                             /* push edi */
            ii(0x1010_bd3e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_bd3f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_bd41, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_bd47, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_bd4a, 5); calld(0x1010_b713, -0x63c);             /* call 0x1010b713 */
            ii(0x1010_bd4f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_bd52, 3); mov(al, memb_a32[ds, eax + 0xc]);       /* mov al, [eax+0xc] */
            ii(0x1010_bd55, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_bd5a, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1010_bd5d, 2); if(jzd(0x1010_bd7f, 0x20)) goto l_0x1010_bd7f; /* jz 0x1010bd7f */
            ii(0x1010_bd5f, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1010_bd64, 5); calld(0x1007_5fdc, -0x9_5d8d);          /* call 0x10075fdc */
            ii(0x1010_bd69, 6); mov(memw_a32[ds, 0x101c_3968], ax);     /* mov [0x101c3968], ax */
            ii(0x1010_bd6f, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1010_bd74, 5); calld(0x1007_5fdc, -0x9_5d9d);          /* call 0x10075fdc */
            ii(0x1010_bd79, 6); mov(memw_a32[ds, 0x101c_3966], ax);     /* mov [0x101c3966], ax */
        l_0x1010_bd7f:
            ii(0x1010_bd7f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_bd82, 7); mov(memd_a32[ds, eax + 0x4], 0x1);      /* mov dword [eax+0x4], 0x1 */
            ii(0x1010_bd89, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_bd8b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_bd8c, 1); popd(edi);                              /* pop edi */
            ii(0x1010_bd8d, 1); popd(esi);                              /* pop esi */
            ii(0x1010_bd8e, 1); popd(edx);                              /* pop edx */
            ii(0x1010_bd8f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_bd90, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_bd91, 1); retd(); return;                         /* ret */
        }
    }
}
