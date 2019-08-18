using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_ae07-8b19e172")]
        public void Method_1012_ae07()
        {
            ii(0x1012_ae07, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_ae0c, 5); calld(Definitions.sys_check_available_stack_size, 0x3_af41); /* call 0x10165d52 */
            ii(0x1012_ae11, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_ae12, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_ae13, 1); pushd(edx);                             /* push edx */
            ii(0x1012_ae14, 1); pushd(esi);                             /* push esi */
            ii(0x1012_ae15, 1); pushd(edi);                             /* push edi */
            ii(0x1012_ae16, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_ae17, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_ae19, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_ae1f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_ae22, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x23);   /* mov byte [0x101c5c1c], 0x23 */
            ii(0x1012_ae29, 5); mov(eax, memd_a32[ds, 0x101c_59cc]);    /* mov eax, [0x101c59cc] */
            ii(0x1012_ae2e, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1012_ae32, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_ae38, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x23);   /* mov word [0x101c5c1f], 0x23 */
            ii(0x1012_ae41, 7); mov(memd_a32[ss, ebp - 0x8], 0x101c_5c21); /* mov dword [ebp-0x8], 0x101c5c21 */
            ii(0x1012_ae48, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_ae4b, 1); inc(eax);                               /* inc eax */
            ii(0x1012_ae4c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_ae4f, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1012_ae52, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_ae55, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_ae58, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
            ii(0x1012_ae5c, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1012_ae60, 3); imul(edx, edx, 0x1e);                   /* imul edx, edx, 0x1e */
            ii(0x1012_ae63, 5); mov(eax, memd_a32[ds, 0x101c_59cc]);    /* mov eax, [0x101c59cc] */
            ii(0x1012_ae68, 5); add(eax, 0x338);                        /* add eax, 0x338 */
            ii(0x1012_ae6d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_ae6f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_ae72, 3); add(eax, 0x5);                          /* add eax, 0x5 */
            ii(0x1012_ae75, 5); calld(Definitions.sys_strcpy, 0x3_b055); /* call 0x10165ecf */
            ii(0x1012_ae7a, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_ae7f, 5); calld(0x1012_5be9, -0x529b);            /* call 0x10125be9 */
            ii(0x1012_ae84, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_ae86, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_ae87, 1); popd(edi);                              /* pop edi */
            ii(0x1012_ae88, 1); popd(esi);                              /* pop esi */
            ii(0x1012_ae89, 1); popd(edx);                              /* pop edx */
            ii(0x1012_ae8a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_ae8b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_ae8c, 1); retd(); return;                         /* ret */
        }
    }
}
