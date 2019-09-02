using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3da8-cbf3439")]
        public void Method_100a_3da8()
        {
            ii(0x100a_3da8, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_3dad, 5); call(Definitions.sys_check_available_stack_size, 0xc_1fa0); /* call 0x10165d52 */
            ii(0x100a_3db2, 1); push(ebx);                              /* push ebx */
            ii(0x100a_3db3, 1); push(ecx);                              /* push ecx */
            ii(0x100a_3db4, 1); push(edx);                              /* push edx */
            ii(0x100a_3db5, 1); push(esi);                              /* push esi */
            ii(0x100a_3db6, 1); push(edi);                              /* push edi */
            ii(0x100a_3db7, 1); push(ebp);                              /* push ebp */
            ii(0x100a_3db8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3dba, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100a_3dc0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_3dc3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_3dc6, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100a_3dc9, 5); call(0x1007_6574, -0x2_d85a);           /* call 0x10076574 */
            ii(0x100a_3dce, 3); mov(al, memb[ds, eax + 77]);            /* mov al, [eax+0x4d] */
            ii(0x100a_3dd1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_3dd6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_3dd8, 2); if(jle(0x100a_3df1, 0x17)) goto l_0x100a_3df1; /* jle 0x100a3df1 */
            ii(0x100a_3dda, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_3ddd, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100a_3de0, 5); call(0x1007_6574, -0x2_d871);           /* call 0x10076574 */
            ii(0x100a_3de5, 3); mov(al, memb[ds, eax + 80]);            /* mov al, [eax+0x50] */
            ii(0x100a_3de8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_3ded, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_3def, 2); if(jg(0x100a_3df3, 2)) goto l_0x100a_3df3; /* jg 0x100a3df3 */
        l_0x100a_3df1:
            ii(0x100a_3df1, 2); jmp(0x100a_3e1c, 0x29); goto l_0x100a_3e1c; /* jmp 0x100a3e1c */
        l_0x100a_3df3:
            ii(0x100a_3df3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_3df6, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100a_3df9, 5); call(0x1007_6574, -0x2_d88a);           /* call 0x10076574 */
            ii(0x100a_3dfe, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100a_3e01, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_3e06, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_3e0c, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100a_3e12, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_3e17, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100a_3e1a, 2); if(jz(0x100a_3e1e, 2)) goto l_0x100a_3e1e; /* jz 0x100a3e1e */
        l_0x100a_3e1c:
            ii(0x100a_3e1c, 2); jmp(0x100a_3e37, 0x19); goto l_0x100a_3e37; /* jmp 0x100a3e37 */
        l_0x100a_3e1e:
            ii(0x100a_3e1e, 5); call(0x1008_9aac, -0x1_a377);           /* call 0x10089aac */
            ii(0x100a_3e23, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_3e25, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100a_3e27, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_3e2a, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100a_3e2d, 5); call(0x1007_65d0, -0x2_d862);           /* call 0x100765d0 */
            ii(0x100a_3e32, 5); call(0x1007_8840, -0x2_b5f7);           /* call 0x10078840 */
        l_0x100a_3e37:
            ii(0x100a_3e37, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3e39, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_3e3a, 1); pop(edi);                               /* pop edi */
            ii(0x100a_3e3b, 1); pop(esi);                               /* pop esi */
            ii(0x100a_3e3c, 1); pop(edx);                               /* pop edx */
            ii(0x100a_3e3d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_3e3e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_3e3f, 1); ret();                                  /* ret */
        }
    }
}
