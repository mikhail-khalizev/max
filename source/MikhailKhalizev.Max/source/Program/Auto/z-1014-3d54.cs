using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_3d54-737e27af")]
        public void Method_1014_3d54()
        {
            ii(0x1014_3d54, 5);  push(0x40);                           /* push 0x40 */
            ii(0x1014_3d59, 5);  call(Definitions.sys_check_available_stack_size, 0x2_1ff4);/* call 0x10165d52 */
            ii(0x1014_3d5e, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_3d5f, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_3d60, 1);  push(edx);                            /* push edx */
            ii(0x1014_3d61, 1);  push(esi);                            /* push esi */
            ii(0x1014_3d62, 1);  push(edi);                            /* push edi */
            ii(0x1014_3d63, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_3d64, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_3d66, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1014_3d6c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_3d6f, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1014_3d72, 6);  mov(ecx, memd[ds, ecx + 362]);        /* mov ecx, [ecx+0x16a] */
            ii(0x1014_3d78, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1014_3d7b, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1014_3d7e, 6);  mov(ebx, memd[ds, ebx + 338]);        /* mov ebx, [ebx+0x152] */
            ii(0x1014_3d84, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1014_3d87, 5);  mov(edx, 0x80);                       /* mov edx, 0x80 */
            ii(0x1014_3d8c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3d8f, 3);  add(eax, 0x4e);                       /* add eax, 0x4e */
            ii(0x1014_3d92, 5);  call(0x1007_68e0, -0xc_d4b7);         /* call 0x100768e0 */
            ii(0x1014_3d97, 5);  call(0x1014_3cec, -0xb0);             /* call 0x10143cec */
            ii(0x1014_3d9c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_3d9f, 7);  mov(memw[ds, edx + 352], ax);         /* mov [edx+0x160], ax */
            ii(0x1014_3da6, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1014_3da9, 6);  mov(ecx, memd[ds, ecx + 364]);        /* mov ecx, [ecx+0x16c] */
            ii(0x1014_3daf, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1014_3db2, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1014_3db5, 6);  mov(ebx, memd[ds, ebx + 340]);        /* mov ebx, [ebx+0x154] */
            ii(0x1014_3dbb, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1014_3dbe, 5);  mov(edx, 0x20);                       /* mov edx, 0x20 */
            ii(0x1014_3dc3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3dc6, 3);  add(eax, 0x4e);                       /* add eax, 0x4e */
            ii(0x1014_3dc9, 5);  call(0x1007_68e0, -0xc_d4ee);         /* call 0x100768e0 */
            ii(0x1014_3dce, 5);  call(0x1014_3cec, -0xe7);             /* call 0x10143cec */
            ii(0x1014_3dd3, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_3dd6, 7);  mov(memw[ds, edx + 354], ax);         /* mov [edx+0x162], ax */
            ii(0x1014_3ddd, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1014_3de0, 6);  mov(ecx, memd[ds, ecx + 360]);        /* mov ecx, [ecx+0x168] */
            ii(0x1014_3de6, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1014_3de9, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1014_3dec, 6);  mov(ebx, memd[ds, ebx + 336]);        /* mov ebx, [ebx+0x150] */
            ii(0x1014_3df2, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1014_3df5, 5);  mov(edx, 0x40);                       /* mov edx, 0x40 */
            ii(0x1014_3dfa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3dfd, 3);  add(eax, 0x4e);                       /* add eax, 0x4e */
            ii(0x1014_3e00, 5);  call(0x1007_68e0, -0xc_d525);         /* call 0x100768e0 */
            ii(0x1014_3e05, 5);  call(0x1014_3cec, -0x11e);            /* call 0x10143cec */
            ii(0x1014_3e0a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_3e0d, 7);  mov(memw[ds, edx + 350], ax);         /* mov [edx+0x15e], ax */
            ii(0x1014_3e14, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3e17, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_3e1a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3e1d, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1014_3e21, 4);  mov(memw[ss, ebp - 32], ax);          /* mov [ebp-0x20], ax */
            ii(0x1014_3e25, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3e28, 3);  mov(eax, memd[ds, eax + 30]);         /* mov eax, [eax+0x1e] */
            ii(0x1014_3e2b, 3);  mov(memd[ss, ebp - 30], eax);         /* mov [ebp-0x1e], eax */
            ii(0x1014_3e2e, 6);  mov(memw[ss, ebp - 26], 0x46);        /* mov word [ebp-0x1a], 0x46 */
            ii(0x1014_3e34, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3e37, 7);  mov(ax, memw[ds, eax + 340]);         /* mov ax, [eax+0x154] */
            ii(0x1014_3e3e, 4);  mov(memw[ss, ebp - 24], ax);          /* mov [ebp-0x18], ax */
            ii(0x1014_3e42, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3e45, 7);  mov(ax, memw[ds, eax + 352]);         /* mov ax, [eax+0x160] */
            ii(0x1014_3e4c, 4);  mov(memw[ss, ebp - 22], ax);          /* mov [ebp-0x16], ax */
            ii(0x1014_3e50, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3e53, 7);  mov(ax, memw[ds, eax + 364]);         /* mov ax, [eax+0x16c] */
            ii(0x1014_3e5a, 4);  mov(memw[ss, ebp - 20], ax);          /* mov [ebp-0x14], ax */
            ii(0x1014_3e5e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3e61, 7);  mov(ax, memw[ds, eax + 376]);         /* mov ax, [eax+0x178] */
            ii(0x1014_3e68, 4);  mov(memw[ss, ebp - 18], ax);          /* mov [ebp-0x12], ax */
            ii(0x1014_3e6c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3e6f, 7);  mov(ax, memw[ds, eax + 388]);         /* mov ax, [eax+0x184] */
            ii(0x1014_3e76, 4);  mov(memw[ss, ebp - 16], ax);          /* mov [ebp-0x10], ax */
            ii(0x1014_3e7a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3e7d, 7);  mov(ax, memw[ds, eax + 400]);         /* mov ax, [eax+0x190] */
            ii(0x1014_3e84, 4);  mov(memw[ss, ebp - 14], ax);          /* mov [ebp-0xe], ax */
            ii(0x1014_3e88, 6);  mov(memw[ss, ebp - 12], 0x216);       /* mov word [ebp-0xc], 0x216 */
            ii(0x1014_3e8e, 6);  mov(memw[ss, ebp - 10], 0x21a);       /* mov word [ebp-0xa], 0x21a */
            ii(0x1014_3e94, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3e97, 3);  add(eax, 0x52);                       /* add eax, 0x52 */
            ii(0x1014_3e9a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_3e9d, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1014_3ea0, 5);  call(0x1014_3187, -0xd1e);            /* call 0x10143187 */
            ii(0x1014_3ea5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3ea8, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_3eab, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3eae, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1014_3eb2, 4);  mov(memw[ss, ebp - 32], ax);          /* mov [ebp-0x20], ax */
            ii(0x1014_3eb6, 6);  mov(memw[ss, ebp - 26], 0xbe);        /* mov word [ebp-0x1a], 0xbe */
            ii(0x1014_3ebc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3ebf, 7);  mov(ax, memw[ds, eax + 342]);         /* mov ax, [eax+0x156] */
            ii(0x1014_3ec6, 4);  mov(memw[ss, ebp - 24], ax);          /* mov [ebp-0x18], ax */
            ii(0x1014_3eca, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3ecd, 7);  mov(ax, memw[ds, eax + 354]);         /* mov ax, [eax+0x162] */
            ii(0x1014_3ed4, 4);  mov(memw[ss, ebp - 22], ax);          /* mov [ebp-0x16], ax */
            ii(0x1014_3ed8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3edb, 7);  mov(ax, memw[ds, eax + 366]);         /* mov ax, [eax+0x16e] */
            ii(0x1014_3ee2, 4);  mov(memw[ss, ebp - 20], ax);          /* mov [ebp-0x14], ax */
            ii(0x1014_3ee6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3ee9, 7);  mov(ax, memw[ds, eax + 378]);         /* mov ax, [eax+0x17a] */
            ii(0x1014_3ef0, 4);  mov(memw[ss, ebp - 18], ax);          /* mov [ebp-0x12], ax */
            ii(0x1014_3ef4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3ef7, 7);  mov(ax, memw[ds, eax + 390]);         /* mov ax, [eax+0x186] */
            ii(0x1014_3efe, 4);  mov(memw[ss, ebp - 16], ax);          /* mov [ebp-0x10], ax */
            ii(0x1014_3f02, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3f05, 7);  mov(ax, memw[ds, eax + 402]);         /* mov ax, [eax+0x192] */
            ii(0x1014_3f0c, 4);  mov(memw[ss, ebp - 14], ax);          /* mov [ebp-0xe], ax */
            ii(0x1014_3f10, 6);  mov(memw[ss, ebp - 12], 0x217);       /* mov word [ebp-0xc], 0x217 */
            ii(0x1014_3f16, 6);  mov(memw[ss, ebp - 10], 0x21a);       /* mov word [ebp-0xa], 0x21a */
            ii(0x1014_3f1c, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1014_3f1f, 5);  call(0x1014_3187, -0xd9d);            /* call 0x10143187 */
            ii(0x1014_3f24, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3f27, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_3f2a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3f2d, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1014_3f31, 4);  mov(memw[ss, ebp - 32], ax);          /* mov [ebp-0x20], ax */
            ii(0x1014_3f35, 6);  mov(memw[ss, ebp - 26], 0x136);       /* mov word [ebp-0x1a], 0x136 */
            ii(0x1014_3f3b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3f3e, 7);  mov(ax, memw[ds, eax + 338]);         /* mov ax, [eax+0x152] */
            ii(0x1014_3f45, 4);  mov(memw[ss, ebp - 24], ax);          /* mov [ebp-0x18], ax */
            ii(0x1014_3f49, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3f4c, 7);  mov(ax, memw[ds, eax + 350]);         /* mov ax, [eax+0x15e] */
            ii(0x1014_3f53, 4);  mov(memw[ss, ebp - 22], ax);          /* mov [ebp-0x16], ax */
            ii(0x1014_3f57, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3f5a, 7);  mov(ax, memw[ds, eax + 362]);         /* mov ax, [eax+0x16a] */
            ii(0x1014_3f61, 4);  mov(memw[ss, ebp - 20], ax);          /* mov [ebp-0x14], ax */
            ii(0x1014_3f65, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3f68, 7);  mov(ax, memw[ds, eax + 374]);         /* mov ax, [eax+0x176] */
            ii(0x1014_3f6f, 4);  mov(memw[ss, ebp - 18], ax);          /* mov [ebp-0x12], ax */
            ii(0x1014_3f73, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3f76, 7);  mov(ax, memw[ds, eax + 386]);         /* mov ax, [eax+0x182] */
            ii(0x1014_3f7d, 4);  mov(memw[ss, ebp - 16], ax);          /* mov [ebp-0x10], ax */
            ii(0x1014_3f81, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3f84, 7);  mov(ax, memw[ds, eax + 398]);         /* mov ax, [eax+0x18e] */
            ii(0x1014_3f8b, 4);  mov(memw[ss, ebp - 14], ax);          /* mov [ebp-0xe], ax */
            ii(0x1014_3f8f, 6);  mov(memw[ss, ebp - 12], 0x218);       /* mov word [ebp-0xc], 0x218 */
            ii(0x1014_3f95, 6);  mov(memw[ss, ebp - 10], 0x21a);       /* mov word [ebp-0xa], 0x21a */
            ii(0x1014_3f9b, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1014_3f9e, 5);  call(0x1014_3187, -0xe1c);            /* call 0x10143187 */
            ii(0x1014_3fa3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_3fa5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_3fa6, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_3fa7, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_3fa8, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_3fa9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_3faa, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_3fab, 1);  ret();                                /* ret */
        }
    }
}
